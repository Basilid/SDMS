namespace System.Windows.Forms
{
    public class CopyButton : Button
    {
        public Control ZContextControl { get; set; }

        public CopyButton()
        {
            Click += CopyButton_Click;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (ZContextControl != null)
                Clipboard.SetText(ZContextControl.Text);
        }
    }
}