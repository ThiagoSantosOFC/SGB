using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace biblioteca.tools
{
        /*
            Section is a class that will be used to save temporary data to be used in the program.

            Section data is save in binary file that contains a list of Section objects.

            The file is located in the same directory as the program.

            The file name is "section.bin".

            work:

            Save data in the file.
            When the program starts, it will read the file and load the data into the program.
            When the program ends, it will save the data in the file.

            all data is saved into a dictionary of Section objects.

            The dictionary key is the name of the section.
            The dictionary value is the Section object.
            
            example:
            Dictionary<string, Section> sections = new Dictionary<string, Section>();
            sections.Add("books", new Section("books", "books.bin"));

            The Section object has the following properties:
            - name: string
            - value: string
            - temporary: bool
            - permanent: bool
        */

    public class Section
    {
        public string? name { get; set; } 
        public string? value { get; set; }
        public bool temporary { get; set; }
        public bool permanent { get; set; }
    }

    public class SectionTools
    {
        //Binary reader and writer

        // dictionary of Section objects
        public Dictionary<string, Section> sections = new Dictionary<string, Section>();

        // file name
        private string fileName = "section.bin";

        // Create section file
        public void CreateSectionFile()
        {
            // create file if not exists
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
        }

        // Save section file
        public void SaveSectionFile()
        {
            // create file if not exists
            CreateSectionFile();

            // open file
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Open)))
            {
                // write sections
                foreach (KeyValuePair<string, Section> section in sections)
                {
                    writer.Write(section.Value.name != null ? section.Value.name : "");
                    writer.Write(section.Value.value != null ? section.Value.value : "");
                    writer.Write(section.Value.temporary);
                    writer.Write(section.Value.permanent);
                }
            }
        }

        // Load section file
        public void LoadSectionFile()
        {
            // create file if not exists
            CreateSectionFile();

            // open file
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                // read sections
                while (reader.PeekChar() > -1)
                {
                    // read section
                    Section section = new Section();
                    section.name = reader.ReadString();
                    section.value = reader.ReadString();
                    section.temporary = reader.ReadBoolean();
                    section.permanent = reader.ReadBoolean();

                    // add section to dictionary
                    sections.Add(section.name, section);
                }
            }
        }


        // Add section
        public void AddSection(string name, string? value, bool temporary, bool permanent)
        {
            // create section
            Section section = new Section();
            section.name = name;
            section.value = value;
            section.temporary = temporary;
            section.permanent = permanent;

            // add section to dictionary
            sections.Add(section.name, section);
        }


        // Remove section
        public void RemoveSection(string name)
        {
            // remove section from dictionary
            sections.Remove(name);
        }

       
        // Get section
        public string? GetSection(string name)
        {
            // get the section.value from the dictionary
            try
            {
                return sections[name].value;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Purge all temporary sections
        public void PurgeTemporarySections()
        {
            // create list of sections to remove
            List<string> sectionsToRemove = new List<string>();

            // add sections to remove
            foreach (KeyValuePair<string, Section> section in sections)
            {
                if (section.Value.temporary)
                {
                    sectionsToRemove.Add(section.Key);
                }
            }

            // remove sections
            foreach (string section in sectionsToRemove)
            {
                sections.Remove(section);
            }
        }

        // Purge all permanent sections
        public void PurgePermanentSections()
        {
            // create list of sections to remove
            List<string> sectionsToRemove = new List<string>();

            // add sections to remove
            foreach (KeyValuePair<string, Section> section in sections)
            {
                if (section.Value.permanent)
                {
                    sectionsToRemove.Add(section.Key);
                }
            }

            // remove sections
            foreach (string section in sectionsToRemove)
            {
                sections.Remove(section);
            }
        }
    }
}
