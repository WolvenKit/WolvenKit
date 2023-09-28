using System.IO;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using static WolvenKit.Modkit.Scripting.HookService;

namespace WolvenKit.Modkit.Scripting;

public interface IHookService
{
    public void RegisterOnExport(OnExportHook hook);
    public void OnExport(ref FileInfo fileInfo, ref GlobalExportArgs args);

    public void RegisterOnPreImport(OnPreImportHook hook);
    public void OnPreImport(ref RedRelativePath rawRelative, ref GlobalImportArgs args, ref DirectoryInfo? outDir);

    public void RegisterOnImportFromJson(OnImportFromJsonHook hook);
    public void OnImportFromJson(ref string jsonText);
}