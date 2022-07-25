using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using To_do_List.Models;

namespace To_do_List
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		private BindingList<To_do_Model> _todoDataList;
		public MainWindow()
		{
			InitializeComponent();
		}
		

		private void Window_Loaded_1(object sender, RoutedEventArgs e)
		{
			_todoDataList = new BindingList<To_do_Model>()
			{
				new To_do_Model(){taskText = "Test" },
				new To_do_Model(){taskText = "Test2" }
			};

			dgTodoList.Items.Clear();
			dgTodoList.ItemsSource = _todoDataList;
            _todoDataList.ListChanged += _todoDataList_ListChanged;//Реагирование на изменение списка
		 
		}

        private void _todoDataList_ListChanged(object sender, ListChangedEventArgs e) //событие сгенерировалось атоматически ВС - для сохранения на диск даных об изменении
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    break;
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                default:
                    break;
            }
        }
    }
}