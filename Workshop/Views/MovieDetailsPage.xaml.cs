using System;
using Workshop.Models;

namespace Workshop
{
    public partial class MovieDetailsPage : ContentPage
    {
        public MovieDetailsPage(Movie movie)
        {
            InitializeComponent();
            BindingContext = movie;
        }

        private async void OnDetailImageTapped(object? sender, EventArgs e)
        {
            if (BindingContext is Movie movie && !string.IsNullOrEmpty(movie.Poster))
            {
                await Shell.Current.Navigation.PushAsync(new FullscreenImagePage(movie.Poster));
            }
        }
    }
}
