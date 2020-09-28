using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace MessageForYou
{
    class SaveAndSend
    {
        int i = 0;
        Word.Document doc = null;
        Word.Application app;
        string[] data;
        DataTable dt;
        UseDataBase db;
        SendAnEmail mail;
        Word.Bookmarks wBookmarks;
        Word.Range wRange;

        public void WordMarks(string filename, string currDir, string mark1, string mark2, string mark3, string mark4, string group, string parent)
        {
            db = new UseDataBase();
            app = new Word.Application();
            doc = app.Documents.Add(currDir);
            doc.Activate();
            wBookmarks = doc.Bookmarks;
            dt = new DataTable();
            dt = db.SQLQuery("SELECT Teachers.FIO FROM Teachers INNER JOIN Groups ON Groups.idTeacher = Teachers.idTeacher where Groups.Name = '" + mark4 + "'");
            string teacherFio = dt.Rows[0][0].ToString();
            data = new string[4] { mark1, mark2, mark3, teacherFio };
            foreach (Microsoft.Office.Interop.Word.Bookmark mark in wBookmarks)
            {
                wRange = mark.Range;
                wRange.Text = data[i];
                i++;
            }
            i = 0;
            filename += "_" + group + "_" + parent;
            doc.SaveAs(FileName: (Environment.CurrentDirectory + @"\report\" + filename));
            string path = Environment.CurrentDirectory + @"\report\" + filename + ".docx";
            doc.Close();
            doc = null;
            app.Quit();

            dt = db.SQLQuery("SELECT DISTINCT Parents.Email FROM Parents, Groups INNER JOIN ParentsSudents ON ParentsSudents.idParent = Parents.idParent INNER JOIN Students ON Students.idGroup = Groups.idGroup AND ParentsSudents.idStudent = Students.idStudent WHERE Groups.Name = '"+ group +"' and Parents.FIO = '"+parent+"'");
            string ParentEmail = dt.Rows[0][0].ToString();

            mail = new SendAnEmail();
            mail.MultiMessage(ParentEmail, "Уведомление от РКРИПТ", "", @path);

        }

        public void WordMarks(string filename, string currDir, string mark1, string mark2, string mark3, string mark4, string mark5, string group, string parent)
        {
            db = new UseDataBase();
            app = new Word.Application();
            doc = app.Documents.Add(currDir);
            doc.Activate();
            wBookmarks = doc.Bookmarks;
            dt = new DataTable();
            dt = db.SQLQuery("SELECT Teachers.FIO FROM Teachers INNER JOIN Groups ON Groups.idTeacher = Teachers.idTeacher where Groups.Name = '" + mark5 + "'");
            string teacherFio = dt.Rows[0][0].ToString();
            data = new string[5] { mark1, mark2, mark3, mark4, teacherFio };
            foreach (Microsoft.Office.Interop.Word.Bookmark mark in wBookmarks)
            {
                wRange = mark.Range;
                wRange.Text = data[i];
                i++;
            }
            i = 0;
            filename += "_" + group + "_" + parent;
            doc.SaveAs(FileName: (Environment.CurrentDirectory + @"\report\" + filename));
            string path = Environment.CurrentDirectory + @"\report\" + filename + ".docx";
            doc.Close();
            doc = null;
            app.Quit();

            dt = db.SQLQuery("SELECT DISTINCT Parents.Email FROM Parents, Groups INNER JOIN ParentsSudents ON ParentsSudents.idParent = Parents.idParent INNER JOIN Students ON Students.idGroup = Groups.idGroup AND ParentsSudents.idStudent = Students.idStudent WHERE Groups.Name = '" + group + "' and Parents.FIO = '" + parent + "'");
            string ParentEmail = dt.Rows[0][0].ToString();

            mail = new SendAnEmail();
            mail.MultiMessage(ParentEmail, "Уведомление от РКРИПТ", "", @path);
        }
    }
}
