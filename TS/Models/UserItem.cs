using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TS.Models
{
    public class UserItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Address { get; set; }

        [Column(TypeName = "datetime2")]
        public required DateTime JoiningDate { get; set; }

        public required string Designation { get; set; }

        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
