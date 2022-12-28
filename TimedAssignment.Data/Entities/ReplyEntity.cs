using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TimedAssignment.Data.Entities
{
    public class ReplyEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Comment))]
        public int CommentEntityId { get; set; }

        public virtual CommentEntity Comment { get; set; }

        [Required]
        public string Text { get; set; }

        public Guid AuthorId { get; set; }
    }
}