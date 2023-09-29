using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDoX
{
    [Serializable]
    public class SDoXDocument
    {
        public string Description;
        public string Author;
        public string Title;
        public string Content;
        public DateTime DateCreated;
        public DateTime DateUpdated;

        public SDoXDocument(string Title, string Author, string Content, string Description = "This Document has no Description")
        {
            this.Title = Title;
            this.Author = Author;
            this.Content = Content;
            this.Description = Description;
            this.DateCreated = DateTime.Now;
            this.DateUpdated = DateTime.Now;
        }

        public void setTitle(string Title)
        {
            this.Title = Title;
            this.DateUpdated = DateTime.Now;
        }

        public void setContent(string Content)
        {
            this.Content = Content;
            this.DateUpdated = DateTime.Now;
        }

        public void setDescription(string Description)
        {
            this.Description = Description;
            this.DateUpdated = DateTime.Now;
        }
    }
}
