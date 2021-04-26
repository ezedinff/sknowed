using System;
using System.ComponentModel.DataAnnotations;
namespace Sknowed.Core.Entities.User
{
    public class User : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactEmail { get; set; }
        public string ProfileImage { get; set; }
    }
}
