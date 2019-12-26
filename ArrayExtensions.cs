using System;
using System.Linq;

public static class ArrayExtensions
{
    public static T[] Push<T>(this T[] source, T value)
    {
        int newLength = source.Length + 1;
        T[] result = new T[newLength];
        for(int i = 0; i < source.Length; i++)
            result[i] = source[i];

        result[newLength -1] = value;
        return result;
    }
}
