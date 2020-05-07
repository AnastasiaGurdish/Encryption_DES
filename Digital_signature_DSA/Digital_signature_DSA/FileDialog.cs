using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Numerics;

namespace Digital_signature_DSA
{
    class FileDialog
    {
        private string ReadyText = string.Empty;
        private string filePath = string.Empty;
        Encoding enc = Encoding.GetEncoding(65001); //кодировка тхт файла
        public FileDialog() { }
        public string Readytext { get { return ReadyText; } }
        public string FilePath { get { return filePath; } }

        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName; //the path of file
                    var fileStream = openFileDialog1.OpenFile();//Reading the file into a stream
                    using (StreamReader reader = new StreamReader(fileStream, enc))
                    {
                        ReadyText = reader.ReadToEnd();
                    }
                }
            }
        }

        public void SaveEncriptFile(string FileName, List<string> text)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                filePath = FileName; //the path of file
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    foreach (var item in text)
                        streamWriter.WriteLine(item);
                }

            }
        }


        public void SaveDecriptFile(string FileName, string text)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                filePath = FileName; //the path of file
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(text);
                }
            }
        }

    }
}
