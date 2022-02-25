using System;
using System.Collections.Generic;
using System.Linq;

namespace FujiUnityUtilities.Extensions {
    public static class IListExtensions {
        public static int IndexOfFirst<T>(this IList<T> list, Func<T, bool> filter) {
            var elem = list.FirstOrDefault(filter);
            return elem != null ? list.IndexOf(elem) : -1;
        }
    }
}