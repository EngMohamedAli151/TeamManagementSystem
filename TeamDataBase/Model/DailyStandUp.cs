using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDataBase.Model
{
    public class DailyStandUp
    {
        
        public int Id { get; set; }
        public int UserFk { get; set;}
        public DateTime Date { get; set;}
        [MaxLength(250)]
        public string Status { get; set; }

    }
}
