using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public interface MIActions_Table
    {
        List<MedicineStock> Search(List<MedicineStock> stockList, int someKey, string somekey);
        List<MedicineStock> Sort(List<MedicineStock> stockList, int someKey);
        List<MedicineStock> Filter(List<MedicineStock> stockList, int someKey, int someValue);
    }
}
