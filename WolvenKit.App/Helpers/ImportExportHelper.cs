using System;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.App.Helpers;

public class ImportExportHelper(
    ILoggerService loggerService,
    IProjectManager projectManager,
    ISettingsManager settingsManager,
    IPluginService pluginService,
    IModTools modTools,
    IHookService hookService)
{
    #region FinalizeArgs

    public bool Finalize(GlobalExportArgs args) =>
        Finalize(args.Get<GeneralExportArgs>()) &&
        Finalize(args.Get<MeshExportArgs>());

    public bool Finalize(GeneralExportArgs args)
    {
        args.MaterialRepositoryPath = settingsManager.MaterialRepositoryPath;

        return true;
    }

    public bool Finalize(MeshExportArgs args)
    {
        args.MaterialRepo = settingsManager.MaterialRepositoryPath;

        return true;
    }

    public bool Finalize(ImportArgs mainArgs, GlobalImportArgs args) => 
        mainArgs is not ReImportArgs || Finalize(args.Get<ReImportArgs>());

    public bool Finalize(ReImportArgs args)
    {
        if (projectManager.ActiveProject is not { } proj)
        {
            loggerService.Error("No project loaded");
            return false;
        }

        if (!pluginService.IsInstalled(EPlugin.redmod))
        {
            loggerService.Error("Redmod plugin needs to be installed to import animations");
            return false;
        }

        args.Depot = proj.ModDirectory;
        args.RedMod = Path.Combine(settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");

        return true;
    }

    #endregion FinalizeArgs

    #region RedMod

    /// <summary>
    ///  Exports a file from the depot to the outDir with REDmod
    /// </summary>
    /// <param name="depot"></param>
    /// <param name="inputFile"></param>
    /// <param name="outDirectory"></param>
    /// <param name="meshExportArgs"></param>
    /// <returns></returns>
    public async Task<bool> Export(DirectoryInfo depot, FileInfo inputFile, DirectoryInfo outDirectory, MeshExportArgs meshExportArgs)
    {
        var redModPath = Path.Combine(settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
        if (!File.Exists(redModPath))
        {
            loggerService.Error("redMod.exe not found");
            return false;
        }

        var redRelative = new RedRelativePath(depot, inputFile.GetRelativePath(depot));
        var outputPath = new RedRelativePath(outDirectory, inputFile.GetRelativePath(depot)).ChangeExtension(EConvertableOutput.fbx.ToString());
        var xmlPath = new RedRelativePath(outDirectory, inputFile.GetRelativePath(depot)).ChangeExtension("xml");

        var outDir = new FileInfo(outputPath.FullPath).Directory;
        Directory.CreateDirectory(outDir.NotNull().FullName);
        await File.WriteAllTextAsync(xmlPath.FullPath, "");

        var args = RedMod.GetExportArgs(depot, redRelative.RelativePath, new FileInfo(outputPath.FullPath));
        var result = await ExecuteAsync(redModPath, args);

        if (!result || !meshExportArgs.withMaterials)
        {
            return result;
        }

        await using var fs = File.Open(inputFile.FullName, FileMode.Open);
        using var cr = new CR2WReader(fs);

        if (cr.ReadFile(out var cr2W) != EFileReadErrorCodes.NoError)
        {
            throw new Exception();
        }

        modTools.ExportMaterials(cr2W!, outputPath.ToFileInfo(), meshExportArgs);

        return result;
    }

    /// <summary>
    /// Imports a file to the depot
    /// </summary>
    /// <param name="depot"></param>
    /// <param name="inputRelative"></param>
    /// <returns></returns>
    public async Task<bool> Import(DirectoryInfo depot, RedRelativePath inputRelative)
    {
        var redModPath = Path.Combine(settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
        if (!File.Exists(redModPath))
        {
            loggerService.Error("redMod.exe not found");
            return false;
        }

        var inputPath = new FileInfo(inputRelative.FullPath);
        var outputPath = inputRelative.ChangeBaseDir(depot).ChangeExtension(ERedExtension.mesh.ToString());

        var outDir = new FileInfo(outputPath.FullPath).Directory;
        Directory.CreateDirectory(outDir.NotNull().FullName);

        var args = RedMod.GetImportArgs(depot, inputPath, outputPath.RelativePath);
        return await ExecuteAsync(redModPath, args);
    }

    private async Task<bool> ExecuteAsync(string redModPath, string args)
    {
        var workingDir = Path.GetDirectoryName(redModPath);

        loggerService.Info($"WorkDir: {workingDir}");
        loggerService.Info($"Running commandlet: {args}");
        return await ProcessUtil.RunProcessAsync(redModPath, args, workingDir);
    }

    #endregion RedMod

    public async Task<bool> Export(FileInfo cr2WFile, GlobalExportArgs args, DirectoryInfo basedir,
        DirectoryInfo? rawOutDir = null,
        ECookedFileFormat[]? forceBuffers = null) =>
        await Task.Run(async () =>
        {
            hookService.OnExport(ref cr2WFile, ref args);
            if (args.Get<MeshExportArgs>().MeshExporter == MeshExporterType.REDmod)
            {
                return await Export(basedir, cr2WFile, rawOutDir!, args.Get<MeshExportArgs>());
            }

            return modTools.Export(cr2WFile, args, basedir, rawOutDir, forceBuffers);
        });

    public async Task<bool> Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo? outDir = null)
    {
        hookService.OnPreImport(ref rawRelative, ref args, ref outDir);
        if (rawRelative.Extension == ERawFileFormat.fbx.ToString())
        {
            return await Import(outDir!, rawRelative);
        }

        return await modTools.Import(rawRelative, args, outDir, settingsManager.ShowVerboseLogOutput);
        //_hookService.OnPostImport(ref cr2wFile, ref args);
    }
}