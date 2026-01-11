using System;

namespace WolvenKit.Modkit.Extensions;

public static class ArrayExtensions
{
    /// <summary>
    /// Append a string to an existing array of strings (for statically sized arrays)
    /// </summary>
    /// <param name="array"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string[] SetWithResize(this string[] array, string value)
    {
        var newArray = new string[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[^1] = value;

        return newArray;
    }

    public static T[,] SetWithResize<T>(this T[,]? array, int row, int col, T value)
    {
        if (array == null)
        {
            // Create array large enough to hold this position
            var newArray = new T[row + 1, col + 1];
            newArray[row, col] = value;
            return newArray;
        }

        var currentRows = array.GetLength(0);
        var currentCols = array.GetLength(1);

        // We do not need to resize, so we can just append
        if (row < currentRows && col < currentCols)
        {
            array[row, col] = value;
            return array;
        }

        // Calculate new dimensions
        var newRows = Math.Max(row + 1, currentRows);
        var newCols = Math.Max(col + 1, currentCols);

        var result = new T[newRows, newCols];

        // Copy existing values
        for (var i = 0; i < currentRows; i++)
        {
            for (var j = 0; j < currentCols; j++)
            {
                result[i, j] = array[i, j];
            }
        }

        // Set the new value
        result[row, col] = value;

        return result;
    }
}
