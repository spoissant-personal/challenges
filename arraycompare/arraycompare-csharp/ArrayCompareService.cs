using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arraycompare_csharp
{
    public class ArrayCompareResult<T> {
        public List<T> Same { get; set; }
        public List<T> InA { get; set; }
        public List<T> InB { get; set; }
    }

    public class ArrayCompareService
    {
        public ArrayCompareResult<T> Compare<T>(List<T> arr1, List<T> arr2)
        {
            var res = new ArrayCompareResult<T>();

            res.Same = arr1.Where(v => arr2.Contains(v)).ToList();
            res.InA = arr1.Where(v => !res.Same.Contains(v)).ToList();
            res.InB = arr2.Where(v => !res.Same.Contains(v)).ToList();
            return res;
        }
    }
}
