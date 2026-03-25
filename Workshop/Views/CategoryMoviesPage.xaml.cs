using System.Linq;
using Microsoft.Maui.Controls;
using MoviesMiniProject.Models;
using MoviesMiniProject.ViewModels;

namespace MoviesMiniProject.Views;

public partial class CategoryMoviesPage : ContentPage
{
    public CategoryMoviesPage(string category)
    {
        InitializeComponent();

        var viewModel = new MoviesViewModel();

        var filteredMovies = viewModel.Movies
            .Where(m => m.Category == category)
            .ToList();

        MoviesList.ItemsSource = filteredMovies;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = e.CurrentSelection.FirstOrDefault() as Movie;

        if (current == null)
            return;

        await Navigation.PushAsync(new MovieDetailsPage(current));

        // ล้างการเลือก
        if (sender is CollectionView cv)
        {
            cv.SelectedItem = null;
        }
    }
}