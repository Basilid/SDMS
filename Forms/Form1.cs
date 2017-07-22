using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Discord;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SupremeDiscordMessage.Forms;
using SupremeDiscordMessage.Properties;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;

namespace SupremeDiscordMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                pColor.BackColor = colorDialog.Color;
        }

        private async void bSend_Click(object sender, EventArgs e)
        {
            var match = regexWebhook.Match(tbFullWebhook.Text);
            if (!match.Success)
                return;
            var hook = new Discord.Webhook.DiscordWebhookClient(ulong.Parse(match.Groups[1].Value), match.Groups[2].Value);

            var embed = new EmbedBuilder();
            embed.WithDescription(tbBodyMessage.Text);
            int cnt = 0;
            if (cbUseColor.Checked && ++cnt > 0)
                embed.WithColor(new Discord.Color(pColor.BackColor.R, pColor.BackColor.G, pColor.BackColor.B));
            if (!string.IsNullOrEmpty(tbTitle.Text) && ++cnt > 0)
                embed.WithTitle(tbTitle.Text);
            if (!string.IsNullOrEmpty(tbThumbnailUrl.Text) && ++cnt > 0)
                embed.WithThumbnailUrl(tbThumbnailUrl.Text);
            if (!string.IsNullOrEmpty(tbImageUrl.Text) && ++cnt > 0)
                embed.WithImageUrl(tbImageUrl.Text);
            if (!string.IsNullOrEmpty(tbLink.Text) && ++cnt > 0)
                embed.WithUrl(tbLink.Text);
            if (dtpTimestamp.Checked && ++cnt > 0)
                embed.WithTimestamp(new DateTimeOffset(dtpTimestamp.Value.ToUniversalTime()));
            if (!string.IsNullOrEmpty(tbAuthorName.Text) && ++cnt > 0)
                embed.WithAuthor(tbAuthorName.Text
                    , !string.IsNullOrEmpty(tbAuthorAvatarUrl.Text) ? tbAuthorAvatarUrl.Text : null
                    , !string.IsNullOrEmpty(tbAuthorLink.Text) ? tbAuthorLink.Text : null);
            if (!string.IsNullOrEmpty(tbFooterText.Text) && ++cnt > 0)
                embed.WithFooter(tbFooterText.Text
                    , !string.IsNullOrEmpty(tbFooterIconUrl.Text) ? tbFooterIconUrl.Text : null);
            if (cnt > 0)
                await hook.SendMessageAsync("", false, new[] { embed.Build() }, tbSenderName.Text, tbSenderAvatarUrl.Text);
            else
                await hook.SendMessageAsync(tbBodyMessage.Text, false, null, tbSenderName.Text, tbSenderAvatarUrl.Text);
        }

        private readonly Regex regexWebhook
            = new Regex(@"https:\/\/discordapp\.com\/api\/webhooks\/([0-9]+)\/([a-zA-Z0-9-_]+)");

        private void Form1_Shown(object sender, EventArgs e)
        {
            presetsController.LoadFromFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ASIC","SDMS", "presets.json"));
            if (presetsController.Count == 0)
            {
                var pr = new Preset
                {
                    Name = "Новый",
                    IsCurrent = true,
                    ColorARGB = pColor.BackColor.ToArgb()
                };
                presetsController.Add(pr);
            }
            foreach (var preset in presetsController.Items)
                preset.IsChanged = false;
            presetsController.CurrentChanged += presetsController_CurrentChanged;
            var curPre = presetsController.Current = presetsController.FirstOrDefault(s => s.IsCurrent) ?? presetsController[0];
            cbPresets.DataSource = presetsController.Items;
            cbPresets.SelectedItem = curPre;


            webhookDescController.LoadFromFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ASIC", "SDMS", "channels.json"));
            if (webhookDescController.Count == 0)
                webhookDescController.Add(new WebhookDesc { Name = "#general", IsCurrent = true });
            foreach (var hook in webhookDescController)
                hook.IsChanged = false;
            webhookDescController.CurrentChanged += WebhookDescControllerOnCurrentChanged;
            var curHook = webhookDescController.Current = webhookDescController.FirstOrDefault(s => s.IsCurrent) ?? webhookDescController[0];
            cbWebhooks.DataSource = webhookDescController.Items;
            cbWebhooks.SelectedItem = curHook;

            //pbRefresh.BackColor = Color.Transparent;
            //pbRefresh.Image = new Bitmap(Resources.refresh, new Size(16,16));
        }

        private void WebhookDescControllerOnCurrentChanged()
        {
            if (webhookDescController.Current == null)
                return;
            cbWebhooks.SelectedItem = webhookDescController.Current;
            tbFullWebhook.Text = webhookDescController.Current.WebhookURL ?? tbFullWebhook.Text;
        }

        private void presetsController_CurrentChanged()
        {
            if (presetsController.Current == null)
                return;
            cbPresets.SelectedItem = presetsController.Current;
            tbSenderName.Text = presetsController.Current.SenderName ?? tbSenderName.Text;
            tbSenderAvatarUrl.Text = presetsController.Current.SenderAvatarURL ?? tbSenderAvatarUrl.Text;
            if (presetsController.Current.Text != null)
                tbBodyMessage.Text = presetsController.Current.Text;
            if (presetsController.Current.ColorARGB.HasValue)
                pColor.BackColor = Color.FromArgb(presetsController.Current.ColorARGB.Value);
            cbUseColor.Checked = presetsController.Current.IsUseColor ?? cbUseColor.Checked;
            tbTitle.Text = presetsController.Current.Title ?? tbTitle.Text;
            tbThumbnailUrl.Text = presetsController.Current.ThumbnailURL ?? tbThumbnailUrl.Text;
            tbImageUrl.Text = presetsController.Current.ImageURL ?? tbImageUrl.Text;
            tbLink.Text = presetsController.Current.Link ?? tbLink.Text;
            tbAuthorName.Text = presetsController.Current.AuthorName ?? tbAuthorName.Text;
            tbAuthorAvatarUrl.Text = presetsController.Current.AuthorAvatarURL ?? tbAuthorAvatarUrl.Text;
            tbAuthorLink.Text = presetsController.Current.AuthorLink ?? tbAuthorLink.Text;
            tbFooterText.Text = presetsController.Current.FooterText ?? tbFooterText.Text;
            tbFooterIconUrl.Text = presetsController.Current.FooterURLIcon ?? tbFooterIconUrl.Text;
            if (presetsController.Current.Timestamp.HasValue)
            {
                dtpTimestamp.Checked = true;
                dtpTimestamp.Value = presetsController.Current.Timestamp.Value;
            }
            else
                dtpTimestamp.Checked = false;
        }

        readonly PresetsController presetsController = new PresetsController();

        readonly WebhookDescControlller webhookDescController = new WebhookDescControlller();

        private void cbPresets_SelectedValueChanged(object sender, EventArgs e)
        {
            presetsController.Current = cbPresets.SelectedItem as Preset;
        }

        private void cbWebhooks_SelectedValueChanged(object sender, EventArgs e)
        {
            var thisa = Assembly.GetExecutingAssembly();
            webhookDescController.Current = cbWebhooks.SelectedItem as WebhookDesc;
            Text = $"{webhookDescController.Current.Name} - Supreme Discord Message Sender v{thisa.GetName().Version.ToString(3)} by ASiC";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (presetsController.Any(s => s.IsChanged))
                presetsController.SaveToFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ASIC", "SDMS", "presets.json"));
            if (webhookDescController.Any(s => s.IsChanged))
                webhookDescController.SaveToFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ASIC", "SDMS", "channels.json"));
        }

        private void tbSenderName_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.SenderName = tbSenderName.Text;
        }

        private void tbSenderAvatarUrl_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.SenderAvatarURL = tbSenderAvatarUrl.Text;

        }

        private void tbBodyMessage_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.Text = tbBodyMessage.Text;
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.Title = tbTitle.Text;
        }

        private void tbThumbnailUrl_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.ThumbnailURL = tbThumbnailUrl.Text;
        }

        private void tbImageUrl_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.ImageURL = tbImageUrl.Text;
        }

        private void tbLink_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.Link = tbLink.Text;
        }

        private void tbAuthorName_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.AuthorName = tbAuthorName.Text;
        }

        private void tbAuthorAvatarUrl_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.AuthorAvatarURL = tbAuthorAvatarUrl.Text;
        }

        private void tbAuthorLink_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.AuthorLink = tbAuthorLink.Text;
        }

        private void tbFooterText_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.FooterText = tbFooterText.Text;
        }

        private void tbFooterIconUrl_TextChanged(object sender, EventArgs e)
        {
            presetsController.Current.FooterURLIcon = tbFooterIconUrl.Text;
        }

        private void dtpTimestamp_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTimestamp.Checked)
                presetsController.Current.Timestamp = dtpTimestamp.Value;
            else
                presetsController.Current.Timestamp = null;
        }

        private void pColor_BackColorChanged(object sender, EventArgs e)
        {
            presetsController.Current.ColorARGB = pColor.BackColor.ToArgb();
        }

        private void cbUseColor_CheckedChanged(object sender, EventArgs e)
        {
            presetsController.Current.IsUseColor = cbUseColor.Checked;
            pColor.Visible = cbUseColor.Checked;
        }

        private void bDuplicatePreset_Click(object sender, EventArgs e)
        {
            if (presetsController.Current == null)
                return;
            var dlg = new frmStringQuery { Text = "Новое имя пресета", tbString = { Text = presetsController.FindNameFor(presetsController.Current.Name) } };
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;
            var preset = JsonConvert.DeserializeObject<Preset>(JsonConvert.SerializeObject(presetsController.Current));
            preset.Name = dlg.tbString.Text;
            presetsController.Add(preset);
            presetsController.Current = preset;
        }

        private void bEditName_Click(object sender, EventArgs e)
        {
            var dlg = new frmStringQuery { Text = "Новое имя пресета", tbString = { Text = presetsController.Current.Name } };
            if (dlg.ShowDialog(this) == DialogResult.OK)
                presetsController.Current.Name = dlg.tbString.Text;
        }

        private void bRemovePreset_Click(object sender, EventArgs e)
        {
            if (presetsController.Count == 1)
                presetsController.Add(new Preset { Name = "Новый" });
            var cur = presetsController.Current;
            var ind = presetsController.IndexOf(cur);
            presetsController.Remove(cur);
            presetsController.Current = presetsController[Math.Max(0, Math.Min(ind, presetsController.Count - 1))];
        }

        private void bCreatePreset_Click(object sender, EventArgs e)
        {
            var dlg = new frmStringQuery { Text = "Имя нового пресета", tbString = { Text = presetsController.FindNameFor("Заготовка") } };
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;
            var cur = new Preset { Name = dlg.tbString.Text };
            presetsController.Add(cur);
            presetsController.Current = cur;
        }

        private void bCreateChannel_Click(object sender, EventArgs e)
        {
            var dlg = new frmStringQuery { Text = "Имя нового канала", tbString = { Text = webhookDescController.FindNameFor("#general") } };
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;
            var cur = new WebhookDesc { Name = dlg.tbString.Text };
            webhookDescController.Add(cur);
            webhookDescController.Current = cur;
        }

        private void bDuplicateChannel_Click(object sender, EventArgs e)
        {
            if (webhookDescController.Current == null)
                return;
            var dlg = new frmStringQuery { Text = "Новое имя канала", tbString = { Text = webhookDescController.FindNameFor(webhookDescController.Current.Name) } };
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;
            var webhook = JsonConvert.DeserializeObject<WebhookDesc>(JsonConvert.SerializeObject(webhookDescController.Current));
            webhook.Name = dlg.tbString.Text;
            webhookDescController.Add(webhook);
            webhookDescController.Current = webhook;
        }

        private void bEditChannelName_Click(object sender, EventArgs e)
        {
            var dlg = new frmStringQuery { Text = "Новое имя канала", tbString = { Text = webhookDescController.Current.Name } };
            if (dlg.ShowDialog(this) == DialogResult.OK)
                webhookDescController.Current.Name = dlg.tbString.Text;
        }

        private void bRemoveChannel_Click(object sender, EventArgs e)
        {
            if (webhookDescController.Count == 1)
                webhookDescController.Add(new WebhookDesc { Name = "#general" });
            var cur = webhookDescController.Current;
            var ind = webhookDescController.IndexOf(cur);
            webhookDescController.Remove(cur);
            webhookDescController.Current = webhookDescController[Math.Max(0, Math.Min(ind, webhookDescController.Count - 1))];
        }

        private void tbFullWebhook_TextChanged_1(object sender, EventArgs e)
        {
            webhookDescController.Current.WebhookURL = tbFullWebhook.Text;
            if (regexWebhook.Match(tbFullWebhook.Text).Success)
            {
                tbFullWebhook.ForeColor = Color.Green;
                bSend.Enabled = true;
            }
            else
            {
                tbFullWebhook.ForeColor = Color.Red;
                bSend.Enabled = false;
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            var res = JsonConvert.DeserializeObject(tbRAW.Text);
            JArray arr = res as JArray;
            JObject jo = res as JObject;
            if (arr != null)
                foreach (var jobj in arr)
                    ImportJObject(jobj);
            if (jo != null)
                ImportJObject(jo);
        }

        private bool ImportJObject(JToken jobj)
        {
            try
            {
                var typeName = jobj.OfType<JProperty>().FirstOrDefault(s => s.Name == "Type");
                switch (typeName.Value.ToString())
                {
                    case nameof(WebhookDesc):
                        webhookDescController.Add(JsonConvert.DeserializeObject<WebhookDesc>(jobj.ToString()));
                        return true;
                    case nameof(Preset):
                        presetsController.Add(JsonConvert.DeserializeObject<Preset>(jobj.ToString()));
                        return true;
                }
            }
            catch (Exception e)
            {

            }
            return false;
        }

        private void bExportCurrentPreset_Click(object sender, EventArgs e)
        {
            var res = JsonConvert.SerializeObject(presetsController.Current, Formatting.Indented);
            if (cbForDiscord.Checked)
                res = $"```JSON{Environment.NewLine}{res}```";
            tbRAW.Text = res;
        }

        private void bExportAllPresets_Click(object sender, EventArgs e)
        {
            var res = JsonConvert.SerializeObject(presetsController.Items, Formatting.Indented);
            if (cbForDiscord.Checked)
                res = $"```JSON{Environment.NewLine}{res}```";
            tbRAW.Text = res;
        }

        private void bExportHook_Click(object sender, EventArgs e)
        {
            var res = JsonConvert.SerializeObject(webhookDescController.Current, Formatting.Indented);
            if (cbForDiscord.Checked)
                res = $"```JSON{Environment.NewLine}{res}```";
            tbRAW.Text = res;
        }

        private void bExportAllHooks_Click(object sender, EventArgs e)
        {
            var res = JsonConvert.SerializeObject(webhookDescController.Items, Formatting.Indented);
            if (cbForDiscord.Checked)
                res = $"```JSON{Environment.NewLine}{res}```";
            tbRAW.Text = res;
        }
    }
}
