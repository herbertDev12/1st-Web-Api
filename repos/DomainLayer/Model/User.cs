using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Model
{
    public class User
    {
        [Key]
        public long userID { get; set; }
        public string userName { get; set; }
        public string userPhone  { get; set; }
        public string userEmail { get; set; }
        public string userAddress { get; set; }
        public DateTime createDateTime { get; set; }
        public DateTime updateDateTime { get; set; }
    }
}
