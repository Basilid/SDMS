using Newtonsoft.Json;

namespace SupremeDiscordMessage
{
    [JsonObject]
    public class WebhookDesc: Descriptor
    {
        #region privates

        private string _webhookURL = "";
        
        #endregion
        
        [JsonProperty]
        public string WebhookURL
        {
            get => _webhookURL;
            set
            {
                if (value == _webhookURL) return;
                _webhookURL = value;
                OnPropertyChanged(nameof(WebhookURL));
            }
        }
    }
}