namespace System.Windows.Forms
{
    public class PasteButton : Button
    {
        public Control ZContextControl { get; set; }

        public PasteButton()
        {
            Click += PasteButton_Click;
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            if (ZContextControl != null)
                ZContextControl.Text = Clipboard.GetText();
        }
    }
}