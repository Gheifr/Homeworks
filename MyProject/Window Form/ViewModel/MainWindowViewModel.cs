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
using System.Windows.Controls;
using System.Windows.Media;


namespace Window_Form.ViewModel
{
    public class MainWindowViewModel : PropertyChangedViewModel
    {
        Tbl Table1 = new Tbl(1);

        public MainWindowViewModel()
        {

            GetTableOrder1 = new RelayCommand(param => HandleGetTableOrder1());
            GetTableOrder2 = new RelayCommand(param => HandleGetTableOrder2());
            GetTableOrder3 = new RelayCommand(param => HandleGetTableOrder3());
            GetTableOrder4 = new RelayCommand(param => HandleGetTableOrder4());

        }
        
        public void HandleGetTableOrder1()
            {
            if (Table1.Order.Count == 0)
            {
                Table1.AddOrderItem("Empty by now");
                Content = Table1.Order;
                ActiveTblChanged(this);

            }

            Content = Table1.Order;
            ActiveTblChanged(this);
        }

        public void HandleGetTableOrder4()
        {
            if (Table1.Order.Count == 0)
            {

                Table1.AddOrderItem("Empty by now");
                Content = Table1.Order;
                ActiveTblChanged(this);
            }

            Content = Table1.Order;
            ActiveTblChanged(this);
        }
        public void HandleGetTableOrder2()
        {
            if (Table1.Order.Count == 0)
            {
                

                Table1.AddOrderItem("Empty by now");
                Content = Table1.Order;
                ActiveTblChanged(this);
            }

            Content = Table1.Order;
            ActiveTblChanged(this);
        }
        public void HandleGetTableOrder3()
        {
            if (Table1.Order.Count == 0)
            {
               
                Table1.AddOrderItem("Empty by now");
                Content = Table1.Order;
                ActiveTblChanged(this);
            }

            Content = Table1.Order;
            ActiveTblChanged(this);
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
        public ICommand GetTableOrder2 { get; private set; }
        public ICommand GetTableOrder3 { get; private set; }
        public ICommand GetTableOrder4 { get; private set; }
        
        private void ChangeActiveTbl(object sender)
        {
            //loop through toggle buttons, switch off all except the pressed one, didn't find solution yet
        }

        
       
    }
    
}
