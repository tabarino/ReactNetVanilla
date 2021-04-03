using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReactNetVanilla.Controllers.Resources
{
    public class CommentResource
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }
    }
}
