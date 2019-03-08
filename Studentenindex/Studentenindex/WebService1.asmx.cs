using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Studentenindex
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        List<Student> StudentList = new List<Student>();

        [WebMethod]
        public bool StudentAnlegen(Student s)
        {
            StudentList.Add(s);
            StudentLog(s);
            return true;
        }

        [WebMethod]
        public void StudenRemove(Student s)
        {
            SutdenLogGet();
            StudentList.Remove(s);
            //im File auch löschen
        }

        [WebMethod]
        public void StudentLog(Student s)
        {
            // Create a string with a line of text.
            //string text = "First line" + Environment.NewLine;

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the text to a new file named "WriteFile.txt".
            //File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), text);

            // Create a string array with the additional lines of text
            string[] lines = { s.Name + "," + s.Geburtsjahr + "," + s.Geschlecht + "," + s.Matrikelnr + "," + s.Studiengang};

            // Append new lines of text to the file
            File.AppendAllLines(Path.Combine(docPath, "WriteFile.txt"), lines);
        }
        [WebMethod]
        public void SutdenLogGet ()
        {

            foreach (var line in File.ReadLines(@"C:\Users\anneb\Documents\WriteFile.txt"))
            {
                //todo
                string[] strs = line.Split(',');
                Student s = new Student();
                s.Name = strs[0];
                s.Geburtsjahr = Int32.Parse(strs[1]);
                s.Geschlecht = strs[2];
                s.Matrikelnr = Int32.Parse(strs[3]);
                s.Studiengang = Int32.Parse(strs[4]);
                StudentList.Add(s);
            };
        }

    }
}
