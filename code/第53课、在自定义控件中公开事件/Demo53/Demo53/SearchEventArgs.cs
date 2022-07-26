using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo53
{
    public class SearchEventArgs: EventArgs
    {
        public string SearchTerm { get; set; }
    }
}
