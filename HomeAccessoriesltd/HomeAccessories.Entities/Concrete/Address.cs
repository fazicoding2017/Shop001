using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.Entities.Concrete
{
 public class Address
  {
    public int AddressId { get; set; }

    public string AddressName { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string Town { get; set; }
    public string City { get; set; }
    public string PostCode { get; set; }
  }
}
