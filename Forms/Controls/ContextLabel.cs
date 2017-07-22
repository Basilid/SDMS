namespace System.Windows.Forms
{
    public class ContextLabel : Label
    {
        private Control _contextControl;
        private CueTextBox _contextControlAsCue;

        public Control ZContextControl
        {
            get => _contextControl;
            set
            {
                if (_contextControl != value)
                {
                    _contextControl = value;
                    if (value != null)
                    {
                        value.TextChanged += Value_TextChanged;
                        _contextControlAsCue = value as CueTextBox;
                        CheckText();
                    }
                }
            }
        }

        private void CheckText()
        {
            if (_contextControlAsCue != null)
                Text = _contextControlAsCue.Cue;
            Visible = !string.IsNullOrEmpty(ZContextControl.Text);
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            CheckText();
        }
    }
}
