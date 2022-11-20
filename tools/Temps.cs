using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace biblioteca.tools
{
    public class temporary
    {
        string? name { get; set; }
        string? value { get; set; }
    }
    public class Temp
    {
        /*
        This create a file for saving temporary data.
        The file is located in the same directory as the program.

        The file have the following structure:
        - name: string
        - value: string

        format:
        name=value

        example:
        book=art of war

        Algorithm:
        1. Read the file line by line.
        2. Split the line into two parts: name and value.
            - All before the first "=" is the name.
            - All after the first "=" is the value.
        2. Add the data to a dictionary.

        */
        //Create txt file for temporary data
        string fileName = "temp.txt";

        //Create dictionary for temporary data
        Dictionary<string, string> temp = new Dictionary<string, string>();

        //Create file
        public void CreateFile()
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
        }

        //Clear file content
        public void ClearFile()
        {
            File.WriteAllText(fileName, "");
        }

        //Read file
        public void ReadFile()
        {
            //Read file
            string[] lines = File.ReadAllLines(fileName);

            //Split lines into name and value
            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                temp.Add(parts[0], parts[1]);
            }
        }

    }
}