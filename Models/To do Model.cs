using System;
using System.Collections.Generic;
using System.Text;

namespace To_do_List.Models
{
	class To_do_Model
	{
		public DateTime CreationDate { get; set; } = DateTime.Now;//когда будет создваться запись, бужет создаваться даьа создания автматически

		private bool _taskIsDone;//переменная типа bool потому что задача либо выполнена либо нет
		private string _taskText; //перемеая для текста задачи

		public bool taskIsDone //свойство для поля со статусом выпонения задачи
		{
			get { return _taskIsDone; }
			set { _taskIsDone = value; }
		}

		
		public string taskText //свойство для поля с текстом задачи
		{
			get { return _taskText; }
			set { _taskText = value; }
		}
	}
}
