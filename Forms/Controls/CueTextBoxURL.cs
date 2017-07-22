using System.Drawing;

namespace System.Windows.Forms
{
    public class CueTextBoxURL: CueTextBox
    {
        public CueTextBoxURL()
        {
            TextChanged += CueTextBoxURL_TextChanged;
        }

        private void CueTextBoxURL_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as CueTextBoxURL;

            tb.ForeColor =
                string.IsNullOrEmpty(tb.Text) ||
                Uri.IsWellFormedUriString(tb.Text, UriKind.Absolute)
                    ? Color.DarkBlue
                    : Color.Red;
        }
    }
}