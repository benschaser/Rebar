using Rebar.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rebar.Controls
{
    /// <summary>
    /// Interaction logic for DirectoryPanel.xaml
    /// </summary>
    public partial class DirectoryPanel : UserControl
    {
        public DirectoryPanel()
        {
            InitializeComponent();
        }
        private string directoryPath = string.Empty;
        public string DirectoryPath
        {
            get { return directoryPath; }
            set { 
                directoryPath = value;
                DirectoryItems.Clear();
                if (Directory.Exists(directoryPath))
                {
                    var dirInfo = new DirectoryInfo(directoryPath);
                    foreach (var file in dirInfo.GetFiles())
                    {
                        DirectoryItems.Add(file);
                    }
                    foreach (var dir in dirInfo.GetDirectories())
                    {
                        DirectoryItems.Add(dir);
                    }
                }
            }
        }
        public ObservableCollection<FileSystemInfo> DirectoryItems { get; set; } = new();

    }
}
