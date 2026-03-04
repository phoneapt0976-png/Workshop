using Workshop.Models;

namespace Workshop
{
    public partial class MoviesPage : ContentPage
    {
        public MoviesPage()
        {
            InitializeComponent();
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var current = e.CurrentSelection?.FirstOrDefault() as Movie;
            if (current == null)
                return;

            // Navigate to details page
            await Shell.Current.Navigation.PushAsync(new MovieDetailsPage(current));

            // clear selection
            if (sender is CollectionView cv)
                cv.SelectedItem = null;
        }
    }
}
