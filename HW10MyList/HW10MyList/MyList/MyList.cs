using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10MyList
{
    public class MyList<T> : IMyList<T>, IComparable<T>
    {
        private T[] _instance;

        public MyList(T[] mas)
        {
            _instance = mas;
        }

        public void Add(T addItem)
        {
            Array.Resize(ref _instance, _instance.Length + 1);
            _instance[_instance.Length - 1] = addItem;
        }

        public void AddRange(T[] collection)
        {
            int index = _instance.Length;
            Array.Resize(ref _instance, index + collection.Length);

            for (int i = 0; i < collection.Length; i++)
            {
                _instance[index] = collection[i];
                index++;
            }
        }

        public bool Remove(T item)
        {
            bool result = false;

            for (int i = 0; i < _instance.Length; i++)
            {
                if (_instance[i].Equals(item))
                {
                    for (int j = i + 1; j < _instance.Length; j++)
                    {
                        _instance[i] = _instance[j];
                        i++;
                    }

                    Array.Resize(ref _instance, _instance.Length - 1);
                    result = true;
                }
            }

            return result;
        }

        public void RemoveAt(int index)
        {
           if (index > 0 && index < _instance.Length)
            {
                for (int j = index + 1; j < _instance.Length; j++)
                {
                    _instance[index] = _instance[j];
                    index++;
                }

                Array.Resize(ref _instance, _instance.Length - 1);
            }
        }

        public void Sort()
        {
            Array.Sort(_instance);

            // T[] ts = MergeSort.Merge_Sort(_instance);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator<T>(_instance);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(_instance);
        }

        public int CompareTo(T? other)
        {
            throw new NotImplementedException();
        }
    }
}
