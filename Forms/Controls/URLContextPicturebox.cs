using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public class URLContextPicturebox : PictureBox
    {
        private Control _contextControl;

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
                        CueTextBox ctb = value as CueTextBox;
                        if (ctb != null)
                            Text = ctb.Cue;
                        CheckText();
                    }
                }
            }
        }

        public bool IsCacheImage { get; set; } = true;

        readonly Regex urlMatch = new Regex(@"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$", RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private void CheckText()
        {
            if (string.IsNullOrEmpty(ZContextControl.Text))
                Image = null;
            if (!urlMatch.IsMatch(ZContextControl.Text))
                return;
            if (IsCacheImage)
                Image = GetOrCacheImage(ZContextControl.Text);
        }

        private async void Value_TextChanged(object sender, EventArgs e)
        {
            await Task.Run((Action)CheckText);
        }

        private Image GetOrCacheImage(string uri)
        {
            var cachePath = Path.Combine(Path.GetTempPath(), "Cache");
            if (!Directory.Exists(cachePath))
                Directory.CreateDirectory(cachePath);
            cachePath = Path.Combine(cachePath, $"{uri.GetHashCode()}.dat");
            if (!File.Exists(cachePath))
                DownloadRemoteImageFile(uri, cachePath);
            return File.Exists(cachePath)
                ? new Bitmap(Image.FromFile(cachePath), new Size(Width, Height))
                : null;
        }

        public static void DownloadRemoteImageFile(string uri, string fileName)
        {
            if (string.IsNullOrEmpty(uri) || !Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                return;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Check that the remote file was found. The ContentType
                // check is performed since a request for a non-existent
                // image file might be redirected to a 404-page, which would
                // yield the StatusCode "OK", even though the image was not
                // found.
                if ((response.StatusCode == HttpStatusCode.OK ||
                     response.StatusCode == HttpStatusCode.Moved ||
                     response.StatusCode == HttpStatusCode.Redirect) &&
                    response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
                {

                    // if the remote file was found, download oit
                    using (Stream inputStream = response.GetResponseStream())
                    using (Stream outputStream = File.OpenWrite(fileName))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        do
                        {
                            bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                            outputStream.Write(buffer, 0, bytesRead);
                        } while (bytesRead != 0);
                    }
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}