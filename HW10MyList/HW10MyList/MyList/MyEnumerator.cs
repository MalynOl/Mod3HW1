using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10MyList
{
    public class MyEnumerator<T> : IEnumerator<T>
    {
        private T[] _mas;
        private int _position = -1;

        public MyEnumerator(T[] mas)
        {
            _mas = mas;
        }

        public T Current
        {
            get
            {
                if (_position == -1 || _position == _mas.Length)
                {
                    throw new InvalidOperationException();
                }

                return _mas[_position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_position < _mas.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
