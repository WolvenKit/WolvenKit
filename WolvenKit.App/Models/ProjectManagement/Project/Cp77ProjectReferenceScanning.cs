using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.Modkit.RED4.Project;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models.ProjectManagement.Project;

public static partial class Cp77ProjectReferenceScanning
{
    /// <summary>
    /// Collects all references from all files in the project, or from a given list of files.
    /// </summary>
    /// <param name="project"></param>
    /// <param name="progressService"></param>
    /// <param name="loggerService"></param>
    /// <param name="filePaths">Optional: A list of files to scan (will use entire project otherwise)
    /// </param>
    /// <returns>A dictionary with lists of referenced files, grouped by containing file's relative path.</returns>
    public static async Task<Dictionary<string, List<string>>> GetAllReferencesAsync(
        this Cp77Project project,
        IProgressService<double> progressService,
        ILoggerService loggerService,
        List<string>? filePaths = null)
    {
        filePaths ??= [];
        if (filePaths.Count == 0)
        {
            filePaths.AddRange(project.ModFiles);
            filePaths.AddRange(project.ResourceFiles);
        }

        filePaths = filePaths
            .Where(f => !AppViewModel.FileScanIgnoredExtensions.Contains(Path.GetExtension(f).ToLower()))
            .ToList();

        progressService?.Report(0);
        var totalFiles = filePaths.Count;
        var processedFiles = 0;
        var progressIncrement = totalFiles > 0 ? 100.0 / totalFiles : 100;

        var references = await Task.Run(() =>
        {
            SortedDictionary<string, List<string>> refsByFile = [];

            Parallel.ForEach(filePaths, filePath =>
            {
                var resourcePaths = project.IsResourceFile(filePath) ? ReadResourceFile(filePath) : ReadCr2WFile(filePath);
                if (resourcePaths.Count == 0)
                {
                    return;
                }

                lock (refsByFile)
                {
                    if (!refsByFile.TryAdd(filePath, resourcePaths))
                    {
                        refsByFile[filePath].AddRange(resourcePaths);
                    }
                }

                // Update progress
                var currentProgress = Interlocked.Increment(ref processedFiles) * progressIncrement;
                progressService?.Report(currentProgress);
            });

            return refsByFile;
        });

        // Order entries by file name
        return references
            .OrderBy(obj => obj.Key)
            .ToDictionary(obj => obj.Key, obj => obj.Value);

        List<string> ReadResourceFile(string filePath)
        {
            var absolutePath = Path.Combine(project.ResourcesDirectory, filePath);
            if (!File.Exists(absolutePath))
            {
                return [];
            }

            var fileContent = File.ReadAllText(absolutePath);

            // Get anything with double or single slashes, then replace double slashes
            return ResourceFilePathsRegex().Matches(fileContent).Where(m => m.Success)
                .Select(m => m.Value.Replace(@"\\", @"\").Replace(@"/", @"\"))
                .Distinct()
                .ToList();
        }

        List<string> ReadCr2WFile(string filePath)
        {
            List<string> resourcePaths = [];
            try
            {
                using (var fs = File.Open(project.GetAbsolutePath(filePath), FileMode.Open))
                using (var cr = new CR2WReader(fs))
                {
                    if (cr.ReadFile(out var cr2WFile) != WolvenKit.RED4.Archive.IO.EFileReadErrorCodes.NoError ||
                        cr2WFile is null)
                    {
                        loggerService.Warning($"Failed to open {filePath}");
                        return resourcePaths;
                    }

                    // check if it's a factory
                    if (cr2WFile.RootChunk is C2dArray { CompiledData: CArray<CArray<CString>> data })
                    {
                        // Grab the second string from CompiledData, if it's a depotPath
                        var paths = data
                            .Where(c => c.Count == 3).Select(cStrings => cStrings[1])
                            .Where(potentialDepotPath =>
                                potentialDepotPath.GetString().Contains(Path.DirectorySeparatorChar))
                            .Select(potentialDepotPath => (string)potentialDepotPath).ToList();
                        resourcePaths.AddRange(paths);
                    }
                    else
                    {
                        foreach (var pathString in cr2WFile.FindType(typeof(IRedRef)).Select(r => r.Value)
                                     .OfType<IRedRef>().Select(r => r.DepotPath.GetResolvedText())
                                     .Where(s => !string.IsNullOrEmpty(s)))
                        {
                            resourcePaths.AddRange(
                                ResolveResourcePaths(pathString, cr2WFile));
                        }

                        // Check redStrings that contain resource paths. This happens inside quest files.
                        foreach (var result in cr2WFile.FindType(typeof(IRedString))
                                     .Select(r => r.Value)
                                     .OfType<IRedString>()
                                     .Select(r => r.GetString())
                                     .Where(s => s?.IsFilePath() == true)
                                )
                        {
                            resourcePaths.AddRange(ResolveResourcePaths(result, cr2WFile));
                        }

                        foreach (var cr2WImport in cr2WFile.Info.Imports)
                        {
                            resourcePaths.AddRange(ResolveResourcePaths(cr2WImport.DepotPath.GetResolvedText(),
                                cr2WFile));
                        }
                    }
                }

                if (resourcePaths.Count == 0)
                {
                    return resourcePaths;
                }
            }
            catch (Exception e)
            {
                loggerService.Error($"Results will be incomplete: Failed to read {filePath} ({e.Message})");
            }

            return resourcePaths.Distinct().ToList();
        }

        // Deal with ArchiveXL substitution and empty/falsy strings
        static IEnumerable<string> ResolveResourcePaths(string? resourcePath, CR2WFile cr2WFile)
        {
            if (string.IsNullOrEmpty(resourcePath))
            {
                return [];
            }

            if (!resourcePath.StartsWith(ArchiveXlHelper.ArchiveXLSubstitutionPrefix))
            {
                return [resourcePath];
            }

            if (cr2WFile.RootChunk is not CMesh mesh)
            {
                return ArchiveXlHelper.ResolveDynamicPaths(resourcePath);
            }

            // TODO: We need to pass the correct material name for the substitution here
            return ArchiveXlHelper.ResolveMaterialSubstitutions(resourcePath, mesh.Appearances);
        }
    }

    private static readonly List<string> s_allowedDeadReferencePartials =
    [
        // in psiberx we trust
        @"archive_xl\characters\common",
        @"archive_xl\characters\head\player_base_heads",
        @"archive_xl\common\null.morphtarget",
        // xbae's photo mode anims - will do nothing if not present
        @"base\animations\xbaebsae\pm_facials",
        // CDPR originals - they have them in all of their NPCS, surely it'll be fine to just ignore them
        @"base\fx\characters\npc\kerenzikov",
        @"base\animations\anim_motion_database\cover_action.csv",
        @"ep1\fx\gameplay\perks_ep1\spy_mantis_blades\spy_perks_charge_hit.effect",
        @"ep1\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_death.anims",
        @"ep1\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_death.anims",
    ];

    public static async Task<IDictionary<string, List<string>>> ScanForBrokenReferencePathsAsync(
        this Cp77Project project,
        IArchiveManager archiveManager,
        ILoggerService loggerService,
        IProgressService<double> progressService,
        Dictionary<string, List<string>>? references = null,
        bool includeModFiles = false)
    {
        references ??= [];
        if (references.Count == 0)
        {
            foreach (var (key, value) in await project.GetAllReferencesAsync(progressService, loggerService))
            {
                references[key] = value;
            }
        }

        SortedDictionary<string, List<string>> brokenReferences = [];

        progressService.Report(0);
        var totalFiles = references.Count;
        var processedFiles = 0;
        var progressIncrement = totalFiles > 0 ? 100.0 / totalFiles : 100;

        await Task.Run(() =>
        {
            Parallel.ForEach(references, (kvp, state) =>
            {
                // path is either not in the project/game, or it is the file itself
                var pathsWithError = kvp.Value
                    .Distinct()
                    .Where(filePath => !string.IsNullOrEmpty(filePath) &&
                                       !filePath.Equals("none", StringComparison.CurrentCultureIgnoreCase) &&
                                       filePath != "0")
                    // Some dead references are allowed - e.g. xbae's facial animation pack or CDPR's known issues
                    .Where(filePath => s_allowedDeadReferencePartials.All(part => !filePath.StartsWith(part)))
                    .Where(filePath =>
                        // Warn if file references itself
                        filePath == kvp.Key ||
                        // File is not in the same mod
                        (!project.ModFiles.Contains(filePath)
                         // Scan for game files and files in other mods (by parameter). We already covered project.
                         && archiveManager.GetGameFile(filePath, includeModFiles, false) is null
                        )
                    )
                    .ToList();

                if (pathsWithError.Count > 0)
                {
                    lock (brokenReferences)
                    {
                        brokenReferences.Add(kvp.Key, pathsWithError);
                    }
                }

                // Update progress
                var currentProgress = Interlocked.Increment(ref processedFiles) * progressIncrement;
                progressService.Report(currentProgress);
            });
        });
        progressService.Completed();
        return brokenReferences;
    }

    /// <summary>
    /// Will match any file paths with forward or backward slashes and a file extension
    /// </summary>
    /// <example>
    /// <code>
    /// folder/subfolder/atelier_icon.inkatlas
    /// folder\subfolder\atelier_icon.inkatlas
    /// folder\\subfolder\\atelier_icon.inkatlas
    /// </code>
    /// </example>
    [GeneratedRegex(@"(((\w+\/)|(\w+\\\\?))+\w+\.\w+)")]
    private static partial Regex ResourceFilePathsRegex();
}
