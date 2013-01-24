using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpx.Domain.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> ExceptWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate) 
        {
            return enumerable.Where(x => !predicate(x));
        }
    }
}
