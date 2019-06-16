using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L2
{
    public class Matrix <T>: IMatrix<T>
    {

        private int xCount;
        private int yCount;
        private T[,] body;
        
        public  Matrix(int xNum, int yNum)
        {
            xCount = xNum;
            yCount = yNum;
            body =  new T[xCount, yCount];
        }

        public int GetCount()
        {
            if (xCount == 0)
                return yCount;
            if (yCount == 0)
                return xCount;
            return xCount*yCount;
        }

        public T GetItem(int x, int y)
        {
            try
            {
                return body[x, y];
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        public void Insert(int x, int y, T item)
        {
            try
            {
                body[x, y] = item;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
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
