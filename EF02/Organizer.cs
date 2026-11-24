using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{

    [Table("EventOrganizers")]
    internal class Organizer
    {

        public int OrganizerID { set; get; }

        [MaxLength(100),Required]
        public string Name { set; get; }
        [MaxLength(150)]
        public string CompanyName { set; get; }
        public int IsVerified { set; get; }
        public OrganizerProfile OrganizerProfile { set; get; }

        public ICollection<Event> Events { set; get; }

    }
}
