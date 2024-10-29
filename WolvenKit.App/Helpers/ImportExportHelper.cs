using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SharpDX.DXGI;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.App.Helpers;

public class ImportExportHelper
{
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly ISettingsManager _settingsManager;
    private readonly IPluginService _pluginService;
    private readonly IModTools _modTools;
    private readonly IHookService _hookService;
    

    public ImportExportHelper(
        ILoggerService loggerService,
        IProjectManager projectManager,
        ISettingsManager settingsManager,
        IPluginService pluginService,
        IModTools modTools,
        IHookService hookService)
    {
        _loggerService = loggerService;
        _projectManager = projectManager;
        _settingsManager = settingsManager;
        _pluginService = pluginService;
        _modTools = modTools;
        _hookService = hookService;
    }

    #region FinalizeArgs

    public bool Finalize(GlobalExportArgs args) =>
        Finalize(args.Get<GeneralExportArgs>()) &&
        Finalize(args.Get<MeshExportArgs>());

    public bool Finalize(GeneralExportArgs args)
    {
        args.MaterialRepositoryPath = _settingsManager.MaterialRepositoryPath;

        return true;
    }

    public bool Finalize(MeshExportArgs args)
    {
        args.MaterialRepo = _settingsManager.MaterialRepositoryPath;

        return true;
    }

    public bool Finalize(ImportArgs mainArgs, GlobalImportArgs args) => 
        mainArgs is not ReImportArgs || Finalize(args.Get<ReImportArgs>());

    public bool Finalize(ReImportArgs args)
    {
        if (_projectManager.ActiveProject is not { } proj)
        {
            _loggerService.Error("No project loaded");
            return false;
        }

        if (!_pluginService.IsInstalled(EPlugin.redmod))
        {
            _loggerService.Error("Redmod plugin needs to be installed to import animations");
            return false;
        }

        args.Depot = proj.ModDirectory;
        args.RedMod = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");

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
    /// <returns></returns>
    public async Task<bool> Export(DirectoryInfo depot, FileInfo inputFile, DirectoryInfo outDirectory, MeshExportArgs meshExportArgs)
    {
        var redModPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
        if (!File.Exists(redModPath))
        {
            _loggerService.Error("redMod.exe not found");
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

        if (result && meshExportArgs.withMaterials)
        {
            await using var fs = File.Open(inputFile.FullName, FileMode.Open);
            using var cr = new CR2WReader(fs);

            if (cr.ReadFile(out var cr2w) != EFileReadErrorCodes.NoError)
            {
                throw new Exception();
            }
            _modTools.ExportMaterials(cr2w!, outputPath.ToFileInfo(), meshExportArgs);
        }
        
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
        var redModPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
        if (!File.Exists(redModPath))
        {
            _loggerService.Error("redMod.exe not found");
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

        _loggerService.Info($"WorkDir: {workingDir}");
        _loggerService.Info($"Running commandlet: {args}");
        return await ProcessUtil.RunProcessAsync(redModPath, args, workingDir);
    }

    #endregion RedMod

    private async Task<bool> ExportMaterialsFromMesh(FileInfo cr2WFile)
    {
        await using var fs1 = File.Open(cr2WFile.FullName, FileMode.Open);
        using var cr1 = new CR2WReader(fs1);

        if (cr1.ReadFile(out var f1) != EFileReadErrorCodes.NoError)
        {
            throw new Exception("Failed to parse file");
        }

        if (f1?.RootChunk is not MorphTargetMesh morphTargetMesh ||
            morphTargetMesh.BaseMesh.DepotPath.GetResolvedText() is not string relativeDestPath)
        {
            return false;
        }

        var outpath = Path.GetDirectoryName(cr2WFile.FullName)?.Replace(
            ProjectResourceHelper.ArchiveSubdirWithSlashes,
            ProjectResourceHelper.RawSubdirWithSlashes
        );

        if (outpath is null)
        {
            return false;
        }

        var pathToProject = outpath.Split(ProjectResourceHelper.SourceSubdirWithSlashes).First();
        var pathToArchive = Path.Join(pathToProject, "source", "archive");

        var materialMeshPath = Path.Join(pathToArchive, relativeDestPath);

        var rawDestPath =
            $"{ProjectResourceHelper.SwitchArchiveRaw(cr2WFile.FullName.Replace(".morphtarget", ".morphtarget.Material"))}.json";

        if (File.Exists(rawDestPath))
        {
            File.Delete(rawDestPath);
        }

        var meshWasAdded = false;
        try
        {
            if (!File.Exists(materialMeshPath))
            {
                ProjectResourceHelper.AddToProject(relativeDestPath);
                meshWasAdded = true;
            }

            if (!File.Exists(materialMeshPath))
            {
                throw new WolvenKitException(-1, $"Failed to add ${relativeDestPath} to project");
            }

            var meshArgs = new MeshExportArgs()
            {
                withMaterials = true, MaterialUncookExtension = EUncookExtension.png, MaterialRepo = outpath,
            };

            await using var fs = File.Open(materialMeshPath, FileMode.Open);
            using var cr = new CR2WReader(fs);

            if (cr.ReadFile(out var cr2W) != EFileReadErrorCodes.NoError)
            {
                throw new WolvenKitException(-1, $"Failed to extract {relativeDestPath}");
            }

            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }

            if (!_modTools.ExportMaterials(cr2W!, new FileInfo(rawDestPath.Replace("Material.", "")), meshArgs))
            {
                throw new WolvenKitException(-1, "Failed to export materials to file");
            }

            return true;

        }
        catch (Exception e)
        {
            _loggerService.Error(e.Message);
        }
        finally
        {
            // clean up after ourselves: don't leave the mesh in the project
            if (meshWasAdded && File.Exists(materialMeshPath))
            {
                File.Delete(materialMeshPath);
            }
        }

        return false;
    }

    public async Task<bool> Export(FileInfo cr2wFile, GlobalExportArgs args, DirectoryInfo basedir, DirectoryInfo? rawoutdir = null, ECookedFileFormat[]? forcebuffers = null) =>
        await Task.Run(async () =>
        {
            _hookService.OnExport(ref cr2wFile, ref args);
            if (args.Get<MeshExportArgs>().MeshExporter == MeshExporterType.REDmod)
            {
                return await Export(basedir, cr2wFile, rawoutdir!, args.Get<MeshExportArgs>());
            }

            if (!_modTools.Export(cr2wFile, args, basedir, rawoutdir, forcebuffers))
            {
                return false;
            }

            if (args.Get<MorphTargetExportArgs>() is not { ExportTextures: true } morphtargetArgs)
            {
                return true;
            }

            if (!await ExportMaterialsFromMesh(cr2wFile))
            {
                _loggerService.Error("Material export failed");
            }

            return true;

        });

    public async Task<bool> Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo? outDir = null)
    {
        _hookService.OnPreImport(ref rawRelative, ref args, ref outDir);
        if (rawRelative.Extension == ERawFileFormat.fbx.ToString())
        {
            return await Import(outDir!, rawRelative);
        }

        return await _modTools.Import(rawRelative, args, outDir, _settingsManager.ShowVerboseLogOutput);
        //_hookService.OnPostImport(ref cr2wFile, ref args);
    }
}