using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SupremeDiscordMessage.Annotations;

namespace SupremeDiscordMessage
{
    [JsonObject]
    public class Preset : Descriptor
    {
        #region privates

        private int? _colorARGB = Color.DodgerBlue.ToArgb();
        private string _senderName = "";
        private string _senderURLAvatar = "";
        private string _text = "";
        private string _title = "";
        private string _thumbnailURL = "";
        private string _pictureURL="";
        private string _link = "";
        private string _authorName = "";
        private string _authorURLAvatar = "";
        private string _authorLink = "";
        private string _footerText = "";
        private string _footerURLIcon = "";
        private DateTime? _timestamp = DateTime.Now;
        private bool? _isUseColor = true;

        #endregion

        [JsonProperty]
        public int? ColorARGB
        {
            get => _colorARGB;
            set
            {
                if (_colorARGB == value)
                    return;
                _colorARGB = value;
                OnPropertyChanged(nameof(ColorARGB));
            }
        }

        public bool? IsUseColor
        {
            get => _isUseColor;
            set
            {
                if (_isUseColor == value)
                    return;
                _isUseColor = value;
                OnPropertyChanged(nameof(IsUseColor));
            }
        }

        [JsonProperty]
        public string SenderName
        {
            get => _senderName;
            set
            {
                if (_senderName == value)
                    return;
                _senderName = value;
                OnPropertyChanged(nameof(SenderName));
            }
        }

        [JsonProperty]
        public string SenderAvatarURL
        {
            get => _senderURLAvatar;
            set
            {
                if (_senderURLAvatar == value)
                    return;
                _senderURLAvatar = value;
                OnPropertyChanged(nameof(SenderAvatarURL));
            }
        }

        [JsonProperty]
        public string Text
        {
            get => _text;
            set
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        [JsonProperty]
        public string Title
        {
            get => _title;
            set
            {
                if (_title == value)
                    return;
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        [JsonProperty]
        public string ThumbnailURL
        {
            get => _thumbnailURL;
            set
            {
                if (_thumbnailURL == value)
                    return;
                _thumbnailURL = value;
                OnPropertyChanged(nameof(ThumbnailURL));
            }
        }

        [JsonProperty]
        public string ImageURL
        {
            get => _pictureURL;
            set
            {
                if (_pictureURL == value)
                    return;
                _pictureURL = value;
                OnPropertyChanged(nameof(ImageURL));
            }
        }

        [JsonProperty]
        public string Link
        {
            get => _link;
            set
            {
                if (_link == value)
                    return;
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }

        [JsonProperty]
        public string AuthorName
        {
            get => _authorName;
            set
            {
                if (_authorName == value)
                    return;
                _authorName = value;
                OnPropertyChanged(nameof(AuthorName));
            }
        }

        [JsonProperty]
        public string AuthorAvatarURL
        {
            get => _authorURLAvatar;
            set
            {
                if (_authorURLAvatar == value)
                    return;
                _authorURLAvatar = value;
                OnPropertyChanged(nameof(AuthorAvatarURL));
            }
        }

        [JsonProperty]
        public string AuthorLink
        {
            get => _authorLink;
            set
            {
                if (_authorLink == value)
                    return;
                _authorLink = value;
                OnPropertyChanged(nameof(AuthorLink));
            }
        }

        [JsonProperty]
        public string FooterText
        {
            get => _footerText;
            set
            {
                if (_footerText == value)
                    return;
                _footerText = value;
                OnPropertyChanged(nameof(FooterText));
            }
        }

        [JsonProperty]
        public string FooterURLIcon
        {
            get => _footerURLIcon;
            set
            {
                if (_footerURLIcon == value)
                    return;
                _footerURLIcon = value;
                OnPropertyChanged(nameof(FooterURLIcon));
            }
        }

        [JsonProperty]
        public DateTime? Timestamp
        {
            get => _timestamp;
            set
            {
                if (_timestamp == value)
                    return;
                _timestamp = value;
                OnPropertyChanged(nameof(Timestamp));
            }
        }
    }
}