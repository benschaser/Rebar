using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebar.Models
{
    public class Item : ClassBase
    {
        public Item() { }
        public string name = "New Item";
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
        private int size = 0;
        public int Size
        {
            get => size;
            set
            {
                size = value;
                OnPropertyChanged();
            }
        }
    }
}
