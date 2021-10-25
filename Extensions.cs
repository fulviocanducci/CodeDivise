using System.Collections;

namespace CodeDivise
{
    public static class Extensions 
    {
        public static void Add(this IList item, decimal value, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                item.Add(value);
            }
        }
    }
}