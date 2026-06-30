namespace Carbonsoft.Common.WebApi.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> AsNotNull<T>(this IEnumerable<T> sequence)
    {
        return sequence ?? [];
    }

    public static bool IsMatchingStringArrays(this string[]? array1, string[]? array2)
    {
        if (array1 == null && array2 == null)
        {
            return true;
        }
        if (array1 == null || array2 == null)
        {
            return false;
        }
        if (array1.Length != array2.Length)
        {
            return false;
        }
        return array1.SequenceEqual(array2);
    }
}
