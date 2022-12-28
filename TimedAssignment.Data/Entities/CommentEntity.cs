using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimedAssignment.Data.Entities
{
    public class CommentEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
        public List<ReplyEntity> Replies { get; set; }

        //[ForeignKey(nameof(Post))]
        public PostEntity PostId { get; set; }
    }
}