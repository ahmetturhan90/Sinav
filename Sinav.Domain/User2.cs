using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinav.Domain
{
    [Table("User2")]
    public class User2
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
