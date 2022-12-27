using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimedAssignment.Data.Entities
{
    public class ReplyEntity
    {
        public int Id { get; set; }

        //[ForeignKey(nameof(Comment))]
        public CommentEntity CommentId { get; set; }

        [Required]
        public string Text { get; set; }

        public Guid AuthorId { get; set; }
    }
}