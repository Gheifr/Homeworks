using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L2
{
    public interface IQueue<T> : IEnumerable<T>
    {
        bool AddItemToQueue(T item);

        bool RemoveItemFromQueue(int itemIndex);

        T GetOutItem();

        int GetCount();
    }
}
