using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Window_Form
{
    class Delegates
    {
        public delegate void TblChanged(object sender);

        public event TblChanged ActiveTblChanged;
    }
}
