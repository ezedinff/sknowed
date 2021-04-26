using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sknowed.Core.Entities.User
{
    public class Instructor : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string FacebookProfileLink { get; set; }
        public string LinkedinProfileLink { get; set; }
        public string TwitterProfileLink { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
