using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Core.DTO
{
    public class DailyStandUpDTO
    {
        public DateOnly Date { get; set; }= new DateOnly();
        [MaxLength(250)]
        public string Status { get; set; }
    }
}
