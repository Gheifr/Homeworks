using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L2
{
    public interface IMatrix<T>:IEnumerable<T>
    {

        
        T GetItem(int x, int y);
        //T GetItem(string name);
        void Insert(int x, int y, T item);

        int GetCount();

    }
}
