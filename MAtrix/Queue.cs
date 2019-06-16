using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L2
{
    public class Queue<T> : IQueue<T>
    {
        private T[] body;
        private int itemsCount;

        public Queue()
        {

        }
        public Queue(int itemsQauntity)
        {
            itemsCount = itemsQauntity;
            body = new T[itemsQauntity];
        }

        public bool RemoveItemFromQueue(int itemIndex)
        {
            if (itemIndex > itemsCount)
            {
                throw new IndexOutOfRangeException();
            }

            var temp = new T[this.itemsCount - 1];

            for (int i = 0; i < this.itemsCount; i++)
            {
                if(i!=itemIndex)
                temp[i] = body[i];
            }
            
            body = null;
            body = new T[temp.Length];

            for (int i = 0; i <= temp.Length -1; i++)
            {
                body[i] = temp[i];
            }
            return true;
        }

        public bool RemoveItemFromQueue(T itemName)
        { 

            for (int i = 0; i < this.itemsCount; i++)
            {
                if (body[i].Equals(itemName))
                {
                    var temp = new T[itemsCount - 1];

                    for (int j = 0; j < this.itemsCount; j++)
                    {
                        if (!body[j].Equals(itemName))
                            temp[j] = body[j];
                    }

                    body = null;
                    body = new T[temp.Length];

                    for (int k = 0; k <= temp.Length - 1; k++)
                    {
                        body[k] = temp[k];
                    }
                    return true;
                } 
            }

            return false;
        }

        public T GetOutItem()
        {
            if (body!=null)
                return body[0];
            throw new IndexOutOfRangeException();
        }
        public bool AddItemToQueue(T item)
        {
            if (item != null)
            {
                var temp = new T[this.itemsCount + 1];
                for(int i=0;i<this.itemsCount;i++)
                {
                    temp[i] = body[i];
                }
                temp[this.itemsCount + 1] = item;

                body = null;
                body = new T[temp.Length];

                for (int i=0; i<= temp.Length-1; i++)
                {
                    body[i] = temp[i];
                }
                return true;
            }
            return false;
        }

        public int GetCount()
        {
            return itemsCount;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T i in body)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
