using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebar.Models
{
    internal class Group : Item
    {
        public Group() { }
        public string description = "New Group";
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Item> Directory = new();
    }
}
