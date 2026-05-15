using System;
using System.Collections;
using WolvenKit.Common.Model;

namespace WolvenKit.App.Comparers;

public class RedTypeTemplateComparer : IComparer
{
    private readonly string PinnedName;

    public RedTypeTemplateComparer(string pinnedName)
    {
        PinnedName = pinnedName;
    }

    public int Compare(object? x, object? y)
    {
        if (ReferenceEquals(x, y))
        {
            return 0;
        }

        if (x is not RedTypeTemplate left)
        {
            return 1;
        }

        if (y is not RedTypeTemplate right)
        {
            return -1;
        }

        var leftIsPinned = string.Equals(left.Name, PinnedName, StringComparison.OrdinalIgnoreCase);
        var rightIsPinned = string.Equals(right.Name, PinnedName, StringComparison.OrdinalIgnoreCase);

        if (leftIsPinned && !rightIsPinned)
        {
            return -1;
        }

        if (!leftIsPinned && rightIsPinned)
        {
            return 1;
        }

        var nameCompare = string.Compare(left.Name, right.Name, StringComparison.CurrentCultureIgnoreCase);
        if (nameCompare != 0)
        {
            return nameCompare;
        }

        return left.Type.CompareTo(right.Type);
    }
}
