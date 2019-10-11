using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiig 
{
    public delegate void ItemPropertyChangedHandler(object sender, PropertyChangedEventArgs e);

    [Serializable]
    public class MinListe<T> : ObservableCollection<T> where T : class, INotifyPropertyChanged
    {
        public event ItemPropertyChangedHandler ItemPropertyChanged;

        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        private void NotifyPropertyChanged(string name)
        {
            NotifyPropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        private void NotifyPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ItemPropertyChangedHandler handler = ItemPropertyChanged;

            if (handler != null)
                handler(sender, e);
        }
        public MinListe(MinListe<T> list)
        {
            foreach (T i in list)
                this.Add(i);
            //this.AddRange(list);
        }

        public new void Add(T item)
        {
            base.Add(item);
            item.PropertyChanged += item_PropertyChanged;
            NotifyPropertyChanged(item, new PropertyChangedEventArgs("New"));
        }

        public new void Remove(T item)
        {
            item.PropertyChanged -= item_PropertyChanged;
            base.Remove(item);
            NotifyPropertyChanged(item, new PropertyChangedEventArgs("Removed"));
        }

        protected override void MoveItem(int oldIndex, int newIndex)
        {
            base.MoveItem(oldIndex, newIndex);
            NotifyPropertyChanged(this[newIndex], new PropertyChangedEventArgs("Move"));
        }

        void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged(sender, e);
        }

        new public T this[int index]
        {
            get
            {
                if (index > Count)
                    throw new IndexOutOfRangeException();
                else
                    return base[index];
            }
            set
            {
                if (index > Count)
                    throw new IndexOutOfRangeException();
                else
                {
                    base[index] = value;
                    NotifyPropertyChanged("New");
                }
            }
        }

        public MinListe()
        {
            
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            MinListe<T> items = new MinListe<T>(this);

            this.Clear();

            foreach (T item in items)
                this.Add(item);
        }
    }
}
