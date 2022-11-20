using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace biblioteca.tools
{
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
        username=joao

        
        */
        //Create txt file for temporary data
        string fileName = "temp.txt";

        public void CreateTempFile()
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
        }

        //Save data in the file
    }
}