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
using To_do_List.Services;

namespace To_do_List
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.Json";
		private BindingList<To_do_Model> _todoDataList;
		private FileIOService _fileIOService;
		public MainWindow()
		{
			InitializeComponent();
		}
		

		private void Window_Loaded_1(object sender, RoutedEventArgs e)
		{
			_fileIOService = new FileIOService(PATH);
			try
			{
				_todoDataList = _fileIOService.LoadData();
			}
            catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
				Close();
            }

			dgTodoList.Items.Clear();
			dgTodoList.ItemsSource = _todoDataList;
            _todoDataList.ListChanged += _todoDataList_ListChanged;//Реагирование на изменение списка
		 
		}

        private void _todoDataList_ListChanged(object sender, ListChangedEventArgs e) //событие сгенерировалось атоматически ВС - для сохранения на диск даных об изменении
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
				try
				{
					_fileIOService.SaveData(sender);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Close();
				}
			}
            
        }
    }
}