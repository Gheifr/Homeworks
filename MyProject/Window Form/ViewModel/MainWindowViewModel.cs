using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Window_Form.ViewModel;
using Window_Form.Commands;
using System.Windows;
using System.Windows.Documents;
using System.Reflection;
using cls;

namespace Window_Form.ViewModel
{
    public class MainWindowViewModel : PropertyChangedViewModel
    {

        Tbl Table1 = new Tbl(1);
        Tbl Table2 = new Tbl(2);
        Tbl Table3 = new Tbl(3);

        public MainWindowViewModel()
        {
            GetTableOrder1 = new RelayCommand(param => HandleGetTableOrder1());
        
        }


        private void HandleGetTableOrder1()
            {




            //MessageBox.Show($"Bingo! This table number is {Table1.GetTblNum()}");
            
            }
        public ICommand GetTableOrder1 { get; private set; }
        public ICommand ShowOrder { get; private set; }

    }
    
}
