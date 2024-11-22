using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class ListSumCalculator<T>
    {
        
        public List<T> ListObject { get; set; }
        public ListSumCalculator(List<T> list)
        {
            this.ListObject = list;
        }
        public int SumBy(Func<T, int> function)
        {
            int sum = 0;
            foreach (var item in this.ListObject)
            {
                sum += function(item);
            }
            return sum;
        }
    }

}
