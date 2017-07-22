using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SupremeDiscordMessage.Annotations;

namespace SupremeDiscordMessage
{
    public abstract class Descriptor : INotifyPropertyChanged
    {
        private string _name = "";
        private bool _isCurrent;

        [JsonProperty]
        public string Type => GetType().Name;

        [JsonProperty]
        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        [JsonProperty]
        public bool IsCurrent
        {
            get => _isCurrent;
            set
            {
                if (value == _isCurrent) return;
                _isCurrent = value;
                OnPropertyChanged();
            }
        }

        [JsonIgnore]
        public bool IsChanged { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            IsChanged = true;
        }
    }
}