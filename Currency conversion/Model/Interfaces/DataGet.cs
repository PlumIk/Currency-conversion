using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conversion
{
    public interface DataGet
    {
        List<string> GetShortNames();
        Dictionary<string, double> GetValues();
        Dictionary<string, string> GetNames();
    }
}
