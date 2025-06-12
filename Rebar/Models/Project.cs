using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebar.Models
{
    internal class Project : ClassBase
    {
        public Project() { }
        public string name = "New Project";
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public DateTime created = DateTime.Now;
        public DateTime Created
        {
            get => created;
            set
            {
                created = value;
                OnPropertyChanged();
            }
        }
        public DateTime modified = DateTime.Now;
        public DateTime Modified
        {
            get => modified;
            set
            {
                modified = value;
                OnPropertyChanged();
            }
        }
    }
}
