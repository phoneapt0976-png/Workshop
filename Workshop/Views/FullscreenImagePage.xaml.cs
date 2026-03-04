using System;
using Microsoft.Maui.Controls;

namespace Workshop
{
    public partial class FullscreenImagePage : ContentPage
    {
        double startScale, currentScale = 1;

        public FullscreenImagePage(string poster)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(poster))
            {
                if (poster.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    FullImage.Source = new UriImageSource { Uri = new Uri(poster), CachingEnabled = true };
                }
                else
                {
                    FullImage.Source = ImageSource.FromFile(poster);
                }
            }
        }

        private async void OnImageTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            if (e.Status == GestureStatus.Started)
            {
                startScale = FullImage.Scale;
            }
            else if (e.Status == GestureStatus.Running)
            {
                var scale = startScale * e.Scale;
                scale = Math.Max(1, Math.Min(scale, 4));
                FullImage.Scale = scale;
            }
        }
    }
}
