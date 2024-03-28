using System;
using System.Collections.Generic;

namespace new_notes.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int? Likes { get; set; }
    }
}
