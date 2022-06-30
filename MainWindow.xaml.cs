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

		private BindingList<To_do_Model> _todoData;
		public MainWindow()
		{
			InitializeComponent();
		}
		//private void Window_Loaded(object sender, RoutedEventArgs e)
		//{
		//	_todoData = new BindingList<To_do_Model>()
		//	{
		//		new To_do_Model(){taskText = "Test" },
		//		new To_do_Model(){taskText = "Test2" }
		//	};
		//	dgTodoList.ItemsSource = _todoData;
		//}

		private void Window_Loaded_1(object sender, RoutedEventArgs e)
		{
			_todoData = new BindingList<To_do_Model>()
			{
				new To_do_Model(){taskText = "Test" },
				new To_do_Model(){taskText = "Test2" }
			};

			dgTodoList.Items.Clear();
			dgTodoList.ItemsSource = _todoData;
		
		}
	}
}
