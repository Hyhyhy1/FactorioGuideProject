using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioGuideProject
{
    public class ListItem<T>
    {
        public T Value { get; set; }
        public ListItem<T> Next { get; set; }
        public ListItem<T> Previous { get; set; }
        public ListItem(T data)
        {
            Value = data;
        }
    }


    public class DoubleSideLinkedList<T> 
    {
        ListItem<T> Head;
        ListItem<T> Tail;
        int Count;

        public void Add(T data)
        {
            ListItem<T> item = new ListItem<T>(data);

            if (Head == null)
                Head = item;
            else
            {
                Tail.Next = item;
                item.Previous = Tail;
            }
            Tail = item;
            Count++;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public ListItem<T> First()
        {
            return Head;
        }
        public ListItem<T> Last()
        {
            return Tail;
        }
    }

    
}
