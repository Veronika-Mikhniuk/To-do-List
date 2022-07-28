using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using To_do_List.Models;

namespace To_do_List.Services
{
    internal class FileIOService
    {
        private readonly string PATH;

        public FileIOService(string path)
        {
            PATH = path;
        }

        public BindingList<To_do_Model> LoadData() 
        {
            var fileExist = File.Exists(PATH);
            if (!fileExist)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<To_do_Model>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<To_do_Model>>(fileText);
            }
        }

        public void SaveData(object _todoDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(_todoDataList);
                writer.WriteLine(output);
            }
        }
    }
}
