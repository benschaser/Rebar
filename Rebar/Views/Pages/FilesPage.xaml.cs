using Rebar.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace Rebar.Views.Pages
{
    public partial class FilesPage : INavigableView<FilesViewModel>
    {
        public FilesViewModel ViewModel { get; }

        public FilesPage(FilesViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
