using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TS.Models
{
    public class TaskItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string taskDescription { get; set; }

        [Column(TypeName = "datetime2")]
        public required DateTime startDate { get; set; }

        [Column(TypeName = "datetime2")]
        public required DateTime endDate { get; set; }

        public required string completed { get; set; }

        //public int? UserId { get; set; }

        //[ForeignKey("UserId")]
        //public UserItem? User { get; set; }
    }
}