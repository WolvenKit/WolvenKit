using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
        // Stack to track opening brace positions and their depths
        var braceStack = new Stack<(int lineIndex, int depth)>();
        var currentDepth = 0;

        // First pass: scan up to targetLine to find all opening braces
        for (var i = 0; i <= targetLine; i++)
        {
            var (opens, closes) = CountBracesInLine(lines[i]);

            // Process closes first (LIFO - matching recent opens)
            for (var j = 0; j < closes; j++)
            {
                if (braceStack.Count > 0)
                {
                    braceStack.Pop();
                }

                currentDepth--;
                if (currentDepth < 0) currentDepth = 0;
            }

            // Then process opens
            for (var j = 0; j < opens; j++)
            {
                braceStack.Push((i, currentDepth));
                currentDepth++;
            }
        }

        // If no opening braces found before our target, return null
        if (braceStack.Count == 0)
        {
            return null;
        }

        // The top of stack is the innermost opening brace before targetLine
        var (startLine, startDepth) = braceStack.Peek();

        // Second pass: find the matching closing brace
        var endLine = -1;
        currentDepth = startDepth; // Reset to depth at start of this block

        for (var i = startLine; i < lines.Length; i++)
        {
            var (opens, closes) = CountBracesInLine(lines[i]);

            // Update depth
            currentDepth += opens;

            // Check each closing brace
            for (var j = 0; j < closes; j++)
            {
                currentDepth--;
                // When depth returns to original level, we found the match
                if (currentDepth == startDepth)
                {
                    endLine = i;
                    break;
                }
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
