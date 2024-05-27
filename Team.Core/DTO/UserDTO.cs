using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Core.DTO
{
    public class UserDTO
    {
       
        public string Name { get; set; }
        public string NickName { get; set; } = string.Empty;
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
