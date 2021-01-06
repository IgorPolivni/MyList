using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHomeWork
{
    public class MyList<T> : IList<T>
    {
        public T[] _array { get; set; }

        public MyList(T[] array)
        {
            _array = array;
        }

        public MyList(int size)
        {
            _array = new T[size];
        }


        public T this[int index] 
        {
            get { return _array[index]; } 
            set { _array[index] = value; } 
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Length()
        {
            return _array.Length;
        }

        public void Add(T item)
        {
            T[] newArray = new T[_array.Length + 1];
            _array.CopyTo(newArray, 0);
            newArray[_array.Length] = item;
            _array = newArray;
        }

        public void Clear()
        {
            T[] newArray = new T[0];
            _array = newArray;
        }

        public bool Contains(T item)
        {
            foreach(var el in _array)
            {
                if (el.Equals(item))
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex >= 0 && arrayIndex < array.Length)
            {
                T[] newArray = new T[array.Length - arrayIndex];
                for (int i = 0, j = arrayIndex; i < newArray.Length; i++, j++)
                {
                    newArray[i] = array[j];
                }
                _array = newArray;
            }
        }

        //??????????????????????????????????????
        public IEnumerator<T> GetEnumerator()
        {
            return null;
        }
        //??????????????????????????????????????


        public int IndexOf(T item)
        {
            int index = 0;
            foreach(var el in _array)
            {
                if (el.Equals(item))
                    break;
                index++;
            }
            return index;
        }

        public void Insert(int index, T item)
        {
            if (index >= 0 && index < _array.Length)
            {
                T[] newArray = new T[_array.Length + 1];
                for (int i = 0, j = 0; i < newArray.Length; i++)
                {
                    if (i == index)
                        newArray[i] = item;
                    else
                    {
                        newArray[i] = _array[j];
                        j++;
                    }
                }
                _array = newArray;
            }
        }

        public bool Remove(T item)
        {
            bool thereIs = false;
            int index = 0;
            for(int i = 0;i<_array.Length;i++)
            {
                if (item.Equals(_array[i]))
                {
                    thereIs = true;
                    index = i;
                }

            }
            if (thereIs)
            {
                T[] newArray = new T[_array.Length - 1];
                for (int i = 0, j = 0; i < _array.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[j] = _array[i];
                        j++;
                    }
                }
                _array = newArray;

            }
            return thereIs;
        }

        public void RemoveAt(int index)
        {
            if (index>=0 && index < _array.Length)
            {
                T[] newArray = new T[_array.Length-1];
                for (int i = 0,j=0;i< _array.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[j] = _array[i];
                        j++;
                    }
                }
                _array = newArray;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
