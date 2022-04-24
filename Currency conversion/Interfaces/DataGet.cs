using System.Collections.Generic;

namespace Currency_conversion
{
    public interface DataGet
    {
        List<string> GetShortNames();
        Dictionary<string, double> GetValues();
        Dictionary<string, string> GetNames();
    }
}
