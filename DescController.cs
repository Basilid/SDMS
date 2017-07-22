using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SupremeDiscordMessage
{
    public abstract class DescController<T> : IList<T>, INotifyCollectionChanged
        where T: Descriptor
    {
        private T _current;

        public BindingList<T> Items { get; private set; }
            = new BindingList<T>();

        public T Current
        {
            get => _current;
            set
            {
                if (_current == value) return;
                if (_current != null)
                    _current.IsCurrent = false;
                _current = value;
                _current.IsCurrent = true;
                OnCurrentChanged();
            }
        }

        public int Count => Items.Count;
        public bool IsReadOnly => false;

        public event Action CurrentChanged;

        public void LoadFromFile(string path)
        {
            if (!File.Exists(path))
                return;
            foreach (var preset in JsonConvert.DeserializeObject<IList<T>>(File.ReadAllText(path)))
            {
                Add(preset);
            }
        }

        public void SaveToFile(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllText(path, JsonConvert.SerializeObject(Items, Formatting.Indented));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Items).GetEnumerator();
        }

        public virtual void Add(T item)
        {
            item.IsChanged = true;
            Items.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
        }

        public void Clear()
        {
            var oldList = Items;
            Items = new BindingList<T>();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, oldList));
            _current = null;
        }

        public bool Contains(T item)
        {
            return Items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Items.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            if (!Items.Remove(item))
                return false;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            return true;
        }

        public int IndexOf(T item)
        {
            return Items.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            Items.Insert(index, item);
        }

        public void RemoveAt(int index)
        {

            Items.RemoveAt(index);
        }

        public T this[int index]
        {
            get => Items[index];
            set => Items[index] = value;
        }

        protected virtual void OnCurrentChanged()
        {
            CurrentChanged?.Invoke();
        }

        public virtual event NotifyCollectionChangedEventHandler CollectionChanged;

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged?.Invoke(this, e);
        }

        public string FindNameFor(string newNameFor)
        {
            var res = newNameFor;
            var cnt = 0;
            while (Items.Any(s => string.Compare(res, s.Name, StringComparison.CurrentCultureIgnoreCase) == 0))
                res = $"{newNameFor}{++cnt}";
            return res;
        }
    }
}