using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySumLibrary
{
    
    public interface IMoney
    {
        double Sum { get; set; }
        string Currency { get; set; }
        double ExRate { get; set; }

    }
}
