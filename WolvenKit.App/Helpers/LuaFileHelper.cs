using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace WolvenKit.App.Helpers;

public class LuaFileHelper
{
    /// <summary>
    /// Finds the minimum viable chunk containing a string for search and replace in text file
    /// </summary>
    /// <param name="filePath">absolute path to file</param>
    /// <param name="searchString">search string (preferably unique)</param>
    /// <returns></returns>
    public static string? FindChunkContainingString(string filePath, string searchString)
    {
        var lines = File.ReadAllLines(filePath);

        // 1. Find ALL lines containing the search string (not in comments/strings)
        var matches = new List<int>();
        for (var i = 0; i < lines.Length; i++)
        {
            if (ContainsInCode(lines[i], searchString))
            {
                matches.Add(i);
            }
        }

        if (matches.Count == 0)
        {
            return null;
        }

        // 2. For each match, try to extract its containing table
        foreach (var matchIdx in matches)
        {
            var chunk = ExtractSmallestTable(lines, matchIdx);
            if (chunk != null)
            {
                return chunk.TrimEnd();
            }
        }

        return null;
    }

    private static bool ContainsInCode(string line, string searchString)
    {
        // Skip comment-only lines
        line = line.Trim();
        if (line.StartsWith("--"))
        {
            return false;
        }

        // Remove inline comments
        var commentIndex = line.IndexOf("--", StringComparison.Ordinal);
        if (commentIndex >= 0)
        {
            line = line[..commentIndex];
        }

        return line.Contains(searchString);
    }

    private static string? ExtractSmallestTable(string[] lines, int targetLine)
    {
        // Find the nearest opening brace BEFORE target line
        var startLine = -1;
        var braceDepthAtStart = 0;

        // We need to track brace balance to find the correct {
        var currentDepth = 0;

        for (var i = 0; i <= targetLine; i++)
        {
            var (opens, closes) = CountBracesInLine(lines[i]);
            currentDepth += opens - closes;

            if (opens <= 0)
            {
                continue;
            }

            // The depth RIGHT BEFORE this line's braces
            var depthBeforeLine = currentDepth - opens;
            startLine = i;
            braceDepthAtStart = depthBeforeLine;
        }

        if (startLine == -1)
        {
            return null;
        }

        // Now find the matching closing brace
        var endLine = -1;
        currentDepth = braceDepthAtStart;

        for (var i = startLine; i < lines.Length; i++)
        {
            var (opens, closes) = CountBracesInLine(lines[i]);

            // Update depth as we process this line
            // Important: we need to check when we reach depth 0
            for (var j = 0; j < opens; j++)
            {
                currentDepth++;
            }

            for (var j = 0; j < closes; j++)
            {
                currentDepth--;
                if (currentDepth != braceDepthAtStart)
                {
                    continue;
                }

                // When we return to the starting depth, we've found the match
                endLine = i;
                break;
            }

            if (endLine != -1)
            {
                break;
            }
        }

        if (endLine == -1)
        {
            return null;
        }

        // Return full match
        return string.Join("\n", lines, startLine, endLine - startLine + 1);
    }

    private static (int opens, int closes) CountBracesInLine(string line)
    {
        int opens = 0, closes = 0;
        var inString = false;
        var stringChar = '\0';
        var escaped = false;

        foreach (var c in line)
        {
            if (escaped)
            {
                escaped = false;
                continue;
            }

            // Handle escape sequences
            if (c == '\\')
            {
                escaped = true;
                continue;
            }

            switch (inString)
            {
                // Handle strings
                case false when c is '"' or '\'':
                    inString = true;
                    stringChar = c;
                    break;
                case true when c == stringChar:
                    inString = false;
                    break;
            }

            // Count braces only when NOT in strings
            if (inString)
            {
                continue;
            }

            switch (c)
            {
                case '{':
                    opens++;
                    break;
                case '}':
                    closes++;
                    break;
            }
        }

        return (opens, closes);
    }
}
