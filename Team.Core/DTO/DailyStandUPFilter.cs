using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Core.DTO
{
    public class DailyStandUPFilter
    {
        public string Date { get; set; }
        [MaxLength(250)]
        public string Status { get; set; }
    }
}
