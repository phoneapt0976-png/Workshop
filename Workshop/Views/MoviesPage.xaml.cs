using System;
using System.Linq;
using Microsoft.Maui.Controls;
using MoviesMiniProject.Models;
using MoviesMiniProject.ViewModels;

namespace MoviesMiniProject.Views;

public partial class MoviesPage : ContentPage
{
    MoviesViewModel viewModel;

    public MoviesPage()
    {
        InitializeComponent();

        viewModel = new MoviesViewModel();
        MoviesList.ItemsSource = viewModel.Movies;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = e.CurrentSelection?.FirstOrDefault() as Movie;

        if (current == null)
            return;

        await Navigation.PushAsync(new MovieDetailsPage(current));

        if (sender is CollectionView cv)
            cv.SelectedItem = null;
    }

    // 🔎 ฟังก์ชันค้นหาหนัง
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        string keyword = e.NewTextValue?.ToLower() ?? "";

        var filteredMovies = viewModel.Movies
            .Where(m => m.Title.ToLower().Contains(keyword))
            .ToList();

        MoviesList.ItemsSource = filteredMovies;
    }

    private void AllClicked(object sender, EventArgs e)
    {
        MoviesList.ItemsSource = viewModel.Movies;
    }

    private async void DramaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryMoviesPage("Drama"));
    }

    private async void ActionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryMoviesPage("Action"));
    }

    private async void CrimeClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryMoviesPage("Crime"));
    }

    private async void SciFiClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryMoviesPage("SciFi"));
    }

    private async void ThrillerClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryMoviesPage("Thriller"));
    }
}