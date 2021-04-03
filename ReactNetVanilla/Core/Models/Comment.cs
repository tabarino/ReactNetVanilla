using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactNetVanilla.Core.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }
    }
}
