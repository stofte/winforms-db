using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRental.Core.Models
{
    public class Genre : DvdRental.Core.Models.Generated.Genre
    {
        public override string ToString()
        {
            return Name;
        }

    }
}
