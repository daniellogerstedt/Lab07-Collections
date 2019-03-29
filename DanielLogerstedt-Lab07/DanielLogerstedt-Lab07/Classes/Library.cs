using System;
using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] Shelf;
        int NumberOfThings;

        public Library()
        {
            T[] Shelf = new T[10];
            NumberOfThings = 0;
        }

        /// <summary>
        /// Adjusts the size based off how full the Library is. If the Library is more than 3/4 full it doubles the size. If the Library is less than 1/4 full it cuts it in half 
        /// </summary>
        public void AdjustShelfSize()
        {
            if (NumberOfThings > (Shelf.Length * 3 / 4))
            {
                T[] array = new T[Shelf.Length * 2];
                for (int i = 0; i < Shelf.Length; i++)
                {
                    array[i] = Shelf[i];
                }
                Shelf = array;
                AdjustShelfSize();
            }
            else if (NumberOfThings < (Shelf.Length * 1 / 4) && Shelf.Length > 10)
            {
                T[] array = new T[Shelf.Length / 2];
                for (int i = 0; i < Shelf.Length; i++)
                {
                    array[i] = Shelf[i];
                }
                Shelf = array;
                AdjustShelfSize();
            }
        }

        /// <summary>
        /// Adds an item to the Library and increments the count of items.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(T item)
        {
            NumberOfThings++;
            Shelf[NumberOfThings] = item;
            AdjustShelfSize();
        }

        /// <summary>
        /// Removes a specified item from the Library.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(T item)
        {
            bool found = false;
            for (int i = 0; i < Shelf.Length - 1; i++)
            {
                if (Shelf[i].Equals(item) || found)
                {
                    found = true;
                    Shelf[i] = Shelf[i + 1];
                }
            }
            if (found)
            {
                NumberOfThings--;
            }
            AdjustShelfSize();
        }

        /// <summary>
        /// Returns the number of items in the Library as an integer.
        /// </summary>
        /// <returns>The number of items.</returns>
        public int Count()
        {
            return NumberOfThings;
        }

        /// <summary>
        /// .Net 1.0 Support
        /// </summary>
        /// <returns>Generic IEnumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// .Net 1.0 Support
        /// </summary>
        /// <returns>Non Generic IEnumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
