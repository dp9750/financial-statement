using System;
using System.IO;

namespace Financial_statement_v1._2
{
    public class FileHandler
    {
        private Main instance { set; get; }
        private string file { set; get; }

        public FileHandler(Main instance, string file)
        {
            this.instance = instance;
            this.file = file;
        }

        // Reads the file, if process valid lines
        public void ReadFile()
        {
            try {
                StreamReader sr = new StreamReader(file);
                string line = "";
                while ((line = sr.ReadLine()) != null)
                    if (instance.ValidLine(line))
                        instance.ProcessLine(line);
                sr.Close();
            } catch (Exception) {
                Console.WriteLine("Error reading file");
            }
        }

        // Delete the file, re-write only elements that are not the deleted one
        public void DeleteElement(Element e)
        {
            File.Delete(file);

            foreach (Element element in instance.elements)
                if (element.GetID() != e.GetID())
                    WriteToFile(element);

            instance.Update();
            instance.DisableButtons();
        }

        // Append to file according to the type
        public void WriteToFile(Element e)
        {
            if (Balance.ToString() == e.GetType().Name)
                using (StreamWriter sw = File.AppendText(file))
                    sw.WriteLine(e.GetBalance() + ";" + e.GetID() + ";" + e.GetName() + ";" + e.GetCashflow() + ";" + e.GetValue());
            else
                using (StreamWriter sw = File.AppendText(file))
                    sw.WriteLine(e.GetFlow() + ";" + e.GetID() + ";" + e.GetName() + ";" + e.GetCashflow());
        }

    }
}
