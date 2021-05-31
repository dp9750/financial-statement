using System;
using System.IO;

namespace Financial_statement_v1._2
{
    public class FileHandler
    {
        private Main Main;
        private string file;

        public FileHandler(string file)
        {
            this.Main = Main.GetInstance();
            this.file = file;
        }

        // Reads the file, if process valid lines
        public void ReadFile()
        {
            try {
                StreamReader sr = new StreamReader(file);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                    if (Main.ValidLine(line))
                        Main.ProcessLine(line);

                sr.Close();
            } catch (Exception) {
                Console.WriteLine("Error reading file");
            }
        }

        // Delete the file, re-write only elements that are not the deleted one
        public void DeleteElement(Element e)
        {
            File.Delete(file);

            foreach (Element element in Main.elements)
                if (element.GetID() != e.GetID())
                    WriteToFile(element);

            Main.Update();
            Main.DisableButtons();
        }

        // Append to file according to the type
        public void WriteToFile(Element e)
        {
            using (StreamWriter sw = File.AppendText(this.file)) 
            {
                string s = "";

                if (Balance.ToString() == e.GetType().Name)
                    s = e.GetBalance() + ";" + e.GetID() + ";" + e.GetName() + ";" + e.GetCashflow() + ";" + e.GetValue();
                else
                    s = e.GetFlow() + ";" + e.GetID() + ";" + e.GetName() + ";" + e.GetCashflow();

                sw.WriteLine(s);
            }
        }

    }
}
