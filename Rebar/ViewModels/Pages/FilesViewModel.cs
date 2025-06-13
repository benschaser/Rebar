using Rebar.Models;
using System.Collections.ObjectModel;
using System.Windows.Media;
using Wpf.Ui.Abstractions.Controls;

namespace Rebar.ViewModels.Pages
{
    public partial class FilesViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;

        [ObservableProperty]
        private ObservableCollection<ItemReference> directory = new();

        [RelayCommand]
        private void Update()
        {
            // update list after actions
        }
        public Task OnNavigatedToAsync()
        {
            if (!_isInitialized)
                InitializeViewModel();

            return Task.CompletedTask;
        }
        

        public Task OnNavigatedFromAsync() => Task.CompletedTask;

        private void InitializeViewModel()
        {
            _isInitialized = true;
        }
    }
}
