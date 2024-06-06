using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public interface IActions_Table
    {
        List<Disease> Search(List<Disease> stockList, int someKey, string somekey);
        List<Disease> Sort(List<Disease> stockList, int someKey);
        List<Disease> Filter(List<Disease> stockList, int someKey, int someValue);
    }
}
