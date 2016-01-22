using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSitemap3.Models.DAO
{
    public class BaseEntity
    {

        public DateTime CreateOn { get; set; }

        public DateTime UpdateOn { get; set; }
    }
}