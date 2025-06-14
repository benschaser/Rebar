﻿using Rebar.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace Rebar.Views.Pages
{
    public partial class DataPage : INavigableView<GroupsViewModel>
    {
        public GroupsViewModel ViewModel { get; }

        public DataPage(GroupsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
