using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinqMethods
{
    public static class myLinqExtension
    {
      
        public static T MyFirst<T>(this IEnumerable<T> collection, Func<T,bool> condition)
        {
            foreach (T item in collection)
            {

                if (condition(item))
                {
                    return item;
                    
                }
            }
            throw new InvalidOperationException("No element");

        }
        public static T MyLast<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {

            T lastMatch = default;
            bool found = false;


            foreach (T item in collection)
            {
                if (condition(item))
                {

                    lastMatch = item;
                    found = true;
                }
            }


            if (!found)
            {
                throw new InvalidOperationException("invalid operation");
            }
            return lastMatch;

        }

        public static bool Any<T>(this IEnumerable<T> collection,Predicate<T> predicate)
        {
            foreach(T item in collection)
            {
               if (predicate(item)) return true;
            }

            return false;
        }

        public static IEnumerable<T> MySkipWhile<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            bool skipping = true;

            foreach(T item in collection)
            {
                if (skipping)
                {
                    skipping = predicate(item);
                    if (skipping)
                    continue;

                }

                yield return item;
            }
        }
    }
}
