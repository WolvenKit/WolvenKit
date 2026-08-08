#nullable enable

using Syncfusion.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using WolvenKit.App.Models;

namespace WolvenKit.Helpers;

public static class FileComparer
{
    public sealed class Paths : IComparer<object>, ISortDirection
    {
        public int Compare(object? x, object? y)
        {
            var item1 = x as FileSystemModel;
            var item2 = y as FileSystemModel;
            var c = 0;

            if (item1 != null && item2 == null)
            {
                c = -1;
            }
            else if (item1 == null && item2 != null)
            {
                c = 1;
            }
            else if (item1 != null && item2 != null)
            {
                switch (item1.IsDirectory)
                {
                    case true when !item2.IsDirectory:
                        c = -1;
                        break;
                    case false when item2.IsDirectory:
                        c = 1;
                        break;
                    default:
                    {
                        c = CompareParts();
                        if (c == 0)
                        {
                            c = string.CompareOrdinal(item1.GameRelativePath, item2.GameRelativePath);
                        }

                        break;
                    }
                }
            }

            if (SortDirection == ListSortDirection.Descending)
            {
                c = -c;
            }

            return c;

            int CompareParts()
            {
                var item1Parts = item1.GameRelativePath.Split(Path.DirectorySeparatorChar);
                var item2Parts = item2.GameRelativePath.Split(Path.DirectorySeparatorChar);

                if (item1Parts.Length != item2Parts.Length)
                {
                    return item1Parts.Length.CompareTo(item2Parts.Length);
                }

                for (var i = 0; i < Math.Min(item1Parts.Length, item2Parts.Length); i++)
                {
                    var result = string.CompareOrdinal(item1Parts[i], item2Parts[i]);
                    if (result != 0)
                    {
                        return result;
                    }
                }

                return 0;
            }
        }

        public ListSortDirection SortDirection { get; set; }
    }

    public sealed class PathStrings : IComparer<string>, ISortDirection
    {
        public int Compare(string? item1, string? item2)
        {
            var c = 0;

            if (item1 == item2)
            {
                return 0;
            }

            if (item1 != null && item2 == null)
            {
                c = -1;
            }
            else if (item1 == null)
            {
                c = 1;
            }
            else if (item2 != null)
            {
                switch (Directory.Exists(item1))
                {
                    case true when !Directory.Exists(item2):
                        c = -1;
                        break;
                    case false when Directory.Exists(item2):
                        c = 1;
                        break;
                    default:
                    {
                        c = CompareParts();
                        if (c == 0)
                        {
                            c = string.CompareOrdinal(item1, item2);
                        }

                        break;
                    }
                }
            }

            if (SortDirection == ListSortDirection.Descending)
            {
                c = -c;
            }

            return c;

            int CompareParts()
            {
                var item1Parts = item1.Split(Path.DirectorySeparatorChar);
                var item2Parts = item2.Split(Path.DirectorySeparatorChar);

                for (var i = 0; i < Math.Min(item1Parts.Length, item2Parts.Length); i++)
                {
                    var result = string.CompareOrdinal(item1Parts[i], item2Parts[i]);
                    if (result != 0)
                    {
                        return result;
                    }
                }

                return 0;
            }
        }

        public ListSortDirection SortDirection { get; set; }
    }

    public sealed class Sizes : IComparer<object>, ISortDirection
    {
        public int Compare(object? x, object? y)
        {
            var item1 = x as FileSystemModel;
            var item2 = y as FileSystemModel;
            var c = 0;

            if (item1 != null && item2 == null)
            {
                c = -1;
            }
            else if (item1 == null && item2 != null)
            {
                c = 1;
            }
            else if (item1 != null && item2 != null)
            {
                c = item1.FileSize.CompareTo(item2.FileSize);
            }

            if (SortDirection == ListSortDirection.Descending)
            {
                c = -c;
            }

            return c;
        }

        public ListSortDirection SortDirection { get; set; }
    }
}
