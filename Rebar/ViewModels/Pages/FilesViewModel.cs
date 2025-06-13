using Rebar.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media;
using Wpf.Ui.Abstractions.Controls;

namespace Rebar.ViewModels.Pages
{
    public partial class FilesViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;

        [ObservableProperty]
        private ObservableCollection<DriveInfo> drives = new();

        [ObservableProperty]
        private string fullDirectoryPath = string.Empty;

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
            var visibleDrives = DriveInfo.GetDrives().Where(d => d.IsReady).ToList();
            Drives.Clear();
            foreach (var drive in visibleDrives)
            {
                Drives.Add(drive);
            }
            _isInitialized = true;
        }
    }
}
