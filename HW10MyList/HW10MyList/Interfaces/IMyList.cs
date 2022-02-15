using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10MyList
{
    public interface IMyList<T> : IEnumerable<T>
    {
        public void Add(T addItem);

        public void AddRange(T[] collection);

        public bool Remove(T item);

        public void RemoveAt(int index);

        public void Sort();
    }
}
