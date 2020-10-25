using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoYoTestApp.Infrastructure.Data
{
    public class JSONReadWrite
    {
        public JSONReadWrite() { }

        public string Read(string fileName)
        {
            //string root = "wwwroot";
            string root = Directory.GetParent(Environment.CurrentDirectory).FullName;
            var path = string.Format("{0}{1}{2}",root, "\\YoYoTestApp.Core\\", fileName);

            string jsonResult;

            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }
            return jsonResult;
        }

        public void Write(string fileName, string jSONString)
        {
            string root = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var path = string.Format("{0}{1}{2}", root, "\\", fileName);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
        }
    }
}
