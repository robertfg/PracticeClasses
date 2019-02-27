using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class MediaLibrary
    {
        private MediaType[] _items;

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }

        public MediaType GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];
            }
            else
            {
                Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");
                return null;
            }

            //return index < _items.Length
            //    ? _items[index]
            //    : null;
        }
    }
}
