using Syncfusion.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using WolvenKit.App.Models;

namespace WolvenKit.Helpers;

public static class FileComparer
{
    /// <summary>
    /// Sorts the "Name" column of the project explorer grids. Files always sort above directories,
    /// deliberately independent of <see cref="SortDirection"/> - flipping the sort direction only
    /// reverses the name order inside each of the two groups.
    /// </summary>
    public sealed class Nodes : IComparer<object>, ISortDirection
    {
        public int Compare(object x, object y)
        {
            if (x is not FileSystemModel item1)
            {
                return y is FileSystemModel ? 1 : 0;
            }

            if (y is not FileSystemModel item2)
            {
                return -1;
            }

            // Group before direction is applied, so files stay on top in both directions.
            if (item1.IsDirectory != item2.IsDirectory)
            {
                return item1.IsDirectory ? -1 : 1;
            }

            var c = string.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase);
            if (c == 0)
            {
                // Same name except for casing: keep the order stable rather than arbitrary.
                c = string.CompareOrdinal(item1.Name, item2.Name);
            }

            return SortDirection == ListSortDirection.Descending ? -c : c;
        }

        public ListSortDirection SortDirection { get; set; }
    }

    public sealed class Paths : IComparer<object>, ISortDirection
    {
        public int Compare(object x, object y)
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
            else if (item1 != null)
            {
                // Files above directories, in both sort directions - see FileSystemNodeComparer.
                if (item1.IsDirectory != item2.IsDirectory)
                {
                    return item1.IsDirectory ? 1 : -1;
                }

                c = CompareParts();
                if (c == 0)
                {
                    c = string.CompareOrdinal(item1.GameRelativePath, item2.GameRelativePath);
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
        public int Compare(string item1, string item2)
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
            else
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
        public int Compare(object x, object y)
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
            else if (item1 != null)
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
