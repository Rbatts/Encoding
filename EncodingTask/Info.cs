using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EncodingTask
{
    class Info
    {
        public string PubDate;
        public string Title;
        public string Author;
        public int PubDateLength = 10;
        public int TitleLength = 26;
        public int AuthorLength = 31;

        public Info(string PubDate, string Title, string Author)
        {
            this.PubDate = PubDate.PadRight(PubDateLength);
            this.Title = Title.PadLeft(TitleLength);
            this.Author = Author.PadRight(AuthorLength);
        }
    }
}
