using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    public record class Conflicts(
        List<ConflictEntry> Winning,
        List<ConflictEntry> Losing
    );

    public record class ConflictEntry(ulong Hash, int ModIndex);

    public record class ResolvedConflicts(
        List<ResolvedConflictEntry> Winning,
        List<ResolvedConflictEntry> Losing
    );

    public record class ResolvedConflictEntry(string FileName, string ModName);

    public int ConflictsTask(DirectoryInfo path, bool structured)
    {
        #region checks

        path ??= new DirectoryInfo(Path.GetFullPath(Environment.CurrentDirectory));

        if (!path.Exists)
        {
            _loggerService.Error("Incorrect input path");
            return 1;
        }

        // check if game dir
        if (!path.Name.Equals("Cyberpunk 2077"))
        {
            _loggerService.Error("Incorrect input path: Not game folder");
            return 1;
        }
        var gameExe = new FileInfo(Path.Combine(path.FullName, "bin", "x64", "Cyberpunk2077.exe"));
        if (!gameExe.Exists)
        {
            _loggerService.Error("Incorrect input path: Not game folder");
            return 1;
        }

        var legacyModsDir = new DirectoryInfo(Path.Combine(path.FullName, "archive", "pc", "mod"));
        if (!legacyModsDir.Exists)
        {
            _loggerService.Info("No legacy mods loaded");
            return 0;
        }

        #endregion

        _archiveManager.LoadModsArchives(gameExe);
        var mods = _archiveManager.ModArchives.Items.ToList();

        // TODO get correct redmod load order

        var conflictsDict = new Dictionary<IGameArchive, Conflicts>();
        foreach (var mod in mods)
        {
            conflictsDict.Add(mod, new Conflicts(new(), new()));
        }

        for (var i = 1; i < mods.Count; i++)
        {
            var mod = mods[i];
            var modFiles = mod.Files.Keys.ToList();

            // check previous mods
            for (var j = 0; j < i; j++)
            {
                var previousMod = mods[j];
                var previousModFiles = previousMod.Files.Keys.ToList();

                // this mod is winning these conflicts against the previous mod
                // the previous mod is losing the same conflicts against this mod
                var winning = modFiles.Intersect(previousModFiles).ToList();

                foreach (var key in winning)
                {
                    // add losing conflicts to previous mod
                    if (!conflictsDict[previousMod].Losing.Contains(new(key, i)))
                    {
                        conflictsDict[previousMod].Losing.Add(new(key, i));
                    }

                    // add winning conflicts to current mod
                    if (!conflictsDict[previousMod].Losing.Contains(new(key, j)))
                    {
                        conflictsDict[mod].Winning.Add(new(key, j));
                    }
                }
            }
        }

        // print
        if (structured)
        {
            // json
            var outDict = new Dictionary<string, ResolvedConflicts>();
            foreach (var (archive, conflicts) in conflictsDict)
            {
                if (conflicts.Winning.Count + conflicts.Losing.Count == 0)
                {
                    continue;
                }

                outDict.Add(archive.ArchiveRelativePath, new ResolvedConflicts(new(), new()));

                if (conflicts.Losing.Count > 0)
                {
                    foreach (var (hash, modIdx) in conflicts.Losing)
                    {
                        var resolvedHash = _hashService.Get(hash);
                        var resolvedMod = mods[modIdx].ArchiveRelativePath;
                        outDict[archive.ArchiveRelativePath].Losing.Add(new(resolvedHash, resolvedMod));
                    }
                }

                if (conflicts.Winning.Count > 0)
                {
                    foreach (var (hash, modIdx) in conflicts.Winning)
                    {
                        var resolvedHash = _hashService.Get(hash);
                        var resolvedMod = mods[modIdx].ArchiveRelativePath;
                        outDict[archive.ArchiveRelativePath].Losing.Add(new(resolvedHash, resolvedMod));
                    }
                }
            }

            Console.WriteLine(JsonSerializer.Serialize(outDict, new JsonSerializerOptions()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            }));
        }
        else
        {
            // pretty print
            foreach (var (archive, conflicts) in conflictsDict)
            {
                if (conflicts.Winning.Count + conflicts.Losing.Count == 0)
                {
                    continue;
                }

                Console.WriteLine(archive.ArchiveRelativePath);
                for (var i = 0; i < archive.ArchiveRelativePath.Length; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("\n");

                if (conflicts.Losing.Count > 0)
                {
                    Console.WriteLine("\tLosing Conflicts:");

                    var losing = new List<ResolvedConflictEntry>();
                    var max1 = 0;
                    var max2 = 0;

                    foreach (var (hash, modIdx) in conflicts.Losing)
                    {
                        var resolvedHash = _hashService.Get(hash);
                        var resolvedMod = mods[modIdx].ArchiveRelativePath;
                        losing.Add(new(resolvedHash, resolvedMod));

                        max1 = Math.Max(max1, resolvedHash.Length);
                        max2 = Math.Max(max2, resolvedMod.Length);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (var (fileName, modName) in losing)
                    {
                        var formatted = string.Format($"\t{{0,-{max1}}}\t{{1,-{max2}}}", fileName, modName);
                        Console.WriteLine(formatted);
                    }
                    Console.ResetColor();
                    Console.WriteLine("\n");
                }

                if (conflicts.Winning.Count > 0)
                {
                    Console.WriteLine("\tWinning Conflicts:");

                    var winning = new List<ResolvedConflictEntry>();
                    var max1 = 0;
                    var max2 = 0;

                    foreach (var (hash, modIdx) in conflicts.Winning)
                    {
                        var resolvedHash = _hashService.Get(hash);
                        var resolvedMod = mods[modIdx].ArchiveRelativePath;
                        winning.Add(new(resolvedHash, resolvedMod));

                        max1 = Math.Max(max1, resolvedHash.Length);
                        max2 = Math.Max(max2, resolvedMod.Length);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (var (fileName, modName) in winning)
                    {
                        var formatted = string.Format($"\t{{0,-{max1}}}\t{{1,-{max2}}}", fileName, modName);
                        Console.WriteLine(formatted);
                    }
                    Console.ResetColor();
                    Console.WriteLine("\n");
                }
            }
        }

        return 0;
    }
}

