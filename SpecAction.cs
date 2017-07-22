using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SupremeDiscordMessage.Annotations;

namespace SupremeDiscordMessage
{
    public class SpecAction<Tvalue> : SpecAction
    {
        public SpecAction(string text, Action<SpecAction<Tvalue>> action, Tvalue value = default(Tvalue))
            : base(text, null)
        {
            Value = value;
            Action = action;
        }

        public new Action<SpecAction<Tvalue>> Action;

        public override void ExecuteAction()
        {
            Action?.Invoke(this);
        }

        public Tvalue Value { get; set; }
    }

    public class SpecAction : INotifyPropertyChanged
    {
        public SpecAction(string text, Action<SpecAction> action)
        {
            Text = text;
            Action = action;
        }

        public string Text
        {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                OnPropertyChanged();
            }
        }

        public Action<SpecAction> Action;

        public virtual void ExecuteAction()
        {
            Action?.Invoke(this);
        }

        private string _text;

        public override string ToString()
        {
            return Text ?? base.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}