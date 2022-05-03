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

        /// <summary>
        /// добавляет элемент в конец списка
        /// </summary>
        /// <param name="data"></param>
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

        /// <summary>
        /// Удаляет все содержимое списка
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// Возвращает первый элемент списка
        /// </summary>
        /// <returns></returns>
        public ListItem<T> First()
        {
            return Head;
        }
        /// <summary>
        /// возвращает последний элемент списка
        /// </summary>
        /// <returns></returns>
        public ListItem<T> Last()
        {
            return Tail;
        }
    }

    
}
