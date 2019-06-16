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
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;

namespace Window_Form.ViewModel
{
    public class MainWindowViewModel : PropertyChangedViewModel
    {

        Tbl Table1 = new Tbl(1);

        public MainWindowViewModel()
        {
            GetTableOrder1 = new RelayCommand(param => HandleGetTableOrder1());
            ShowOrder = new RelayCommand(param => HandleShowOrder());
        }

        public ObservableCollection<string> HandleShowOrder()
        {
            return Table1.Order;
        }
        
        public void HandleGetTableOrder1()
            {
            if (Table1.Order.Count == 0)
            {
                //MessageBox.Show($"Bingo! This table number is {Table1.GetTblNum()} \nOrder is: {Table1.GetOrder()}");

                Table1.AddOrderItem("Empty by now");
                Content = Table1.Order;
                
            }

            //MessageBox.Show($"Bingo! This table number is {Table1.GetTblNum()} \nOrder is: {Table1.GetOrder()}");
            Content = Table1.Order;
            
            }

        private ObservableCollection<string> _orderText;
        public ObservableCollection<string> Content
        {
            get
            {
                return _orderText;
            }
            set
            {
                _orderText = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand GetTableOrder1 { get; private set; }
        public ICommand ShowOrder { get; private set; }

        
    }
    
}
