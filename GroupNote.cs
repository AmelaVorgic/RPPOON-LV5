using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5RPPOON
{
    class GroupNote : Note
    {
        List<string> authors;
        public GroupNote(string message, string mainAuthor, ITheme theme) : base(message, theme)
        {
            this.authors = new List<string>();
            this.authors.Add(mainAuthor);
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("GROUP REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.WriteLine("Authors:" + AuthorsToString(this.authors));
            Console.ResetColor();
        }
        public void Add(string newAuthor)
        {
            if (this.authors == null)
            {
                this.authors = new List<string>();
                this.authors.Add(newAuthor);
            }
            else
                this.authors.Add(newAuthor);
        }
        public void Remove(string removeAuthor)
        {
            if (this.authors != null)
            {
                if (this.authors.Contains(removeAuthor))
                {
                    int i = authors.IndexOf(removeAuthor);
                    authors.RemoveAt(i);
                }
            }
        }
        public string AuthorsToString(List<string> authors)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string author in this.authors)
            {
                stringBuilder.Append(author + ", ");
            }
            return stringBuilder.ToString();
        }
    }
}
