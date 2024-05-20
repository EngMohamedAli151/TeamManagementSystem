using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDataBase.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string NickName { get; set; }=string.Empty;
        public string Mail { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public string Phone { get; set; }
        

    }
}
