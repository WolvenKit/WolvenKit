using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.App.Services;

public class HashServiceExt : HashService
{
    private readonly ConcurrentDictionary<string, byte> _globalRefCache = new();
    private readonly ConcurrentDictionary<string, byte> _globalTweakCache = new();

    private readonly ConcurrentDictionary<string, byte> _projectRefCache = new();
    private readonly ConcurrentDictionary<string, byte> _projectTweakCache = new();


    public override bool AddResourcePath(string resourcePath)
    {
        if (ResourcePathPool.IsNative(resourcePath))
        {
            return false;
        }

        _globalRefCache.TryAdd(resourcePath, 0);
        _projectRefCache.TryAdd(resourcePath, 0);

        return true;
    }

    public override bool AddTweakName(string tweakName)
    {
        if (TweakDBIDPool.IsNative(tweakName))
        {
            return false;
        }

        _globalTweakCache.TryAdd(tweakName, 0);
        _projectTweakCache.TryAdd(tweakName, 0);

        return true;
    }

    private void MigrateLegacyGlobalCache()
    {
        var customRefsFile = Path.Combine(ISettingsManager.GetAppData(), "user_hashes.txt");
        if (File.Exists(customRefsFile))
        {
            var paths = File.ReadAllLines(customRefsFile);
            foreach (var p in paths)
            {
                ResourcePathPool.AddOrGetHash(p);
                _globalRefCache.TryAdd(p, 0);
            }
            
            File.Delete(customRefsFile);
        }
    }

    public void LoadGlobalCache()
    {
        _globalRefCache.Clear();
        _globalTweakCache.Clear();

        MigrateLegacyGlobalCache();

        var customRefsFile = Path.Combine(ISettingsManager.GetAppData(), "custom_refs.txt");
        if (File.Exists(customRefsFile))
        {
            var paths = File.ReadAllLines(customRefsFile);
            foreach (var p in paths)
            {
                ResourcePathPool.AddOrGetHash(p);
                _globalRefCache.TryAdd(p, 0);
            }
        }

        var customTweaksFile = Path.Combine(ISettingsManager.GetAppData(), "custom_tweaks.txt");
        if (File.Exists(customTweaksFile))
        {
            var paths = File.ReadAllLines(customTweaksFile);
            foreach (var p in paths)
            {
                TweakDBIDPool.AddOrGetHash(p);
                _globalTweakCache.TryAdd(p, 0);
            }
        }
    }

    public void SaveGlobalCache()
    {
        if (!_globalRefCache.IsEmpty)
        {
            var list = _globalRefCache.Keys.ToList();
            list.Sort();

            File.WriteAllLines(Path.Combine(ISettingsManager.GetAppData(), "custom_refs.txt"), list);
        }

        if (!_globalTweakCache.IsEmpty)
        {
            var list = _globalTweakCache.Keys.ToList();
            list.Sort();

            File.WriteAllLines(Path.Combine(ISettingsManager.GetAppData(), "custom_tweaks.txt"), list);
        }
    }

    private void MigrateLegacyProjectCache(Cp77Project project)
    {
        var customRefsFile = Path.Combine(project.ProjectDirectory, "user_hashes.txt");
        if (File.Exists(customRefsFile))
        {
            var paths = File.ReadAllLines(customRefsFile);
            foreach (var p in paths)
            {
                ResourcePathPool.AddOrGetHash(p);
                _globalRefCache.TryAdd(p, 0);
            }

            File.Delete(customRefsFile);
        }
    }

    public void LoadProjectCache(Cp77Project project)
    {
        _projectRefCache.Clear();
        _projectTweakCache.Clear();

        MigrateLegacyProjectCache(project);

        foreach (var p in project.ModFiles.Where(AddResourcePath))
        {
            ResourcePathPool.AddOrGetHash(p);
        }

        var customRefsFile = Path.Combine(project.ProjectDirectory, "custom_refs.txt");
        if (File.Exists(customRefsFile))
        {
            var paths = File.ReadAllLines(customRefsFile);
            foreach (var p in paths)
            {
                if (AddResourcePath(p))
                {
                    ResourcePathPool.AddOrGetHash(p);
                }
            }
        }

        var customTweaksFile = Path.Combine(project.ProjectDirectory, "custom_tweaks.txt");
        if (File.Exists(customTweaksFile))
        {
            var paths = File.ReadAllLines(customTweaksFile);
            foreach (var p in paths)
            {
                if (AddTweakName(p))
                {
                    TweakDBIDPool.AddOrGetHash(p);
                }
            }
        }
    }

    public void SaveProjectCache(Cp77Project project)
    {
        if (!_projectRefCache.IsEmpty)
        {
            var list = _projectRefCache.Keys.ToList();
            list.Sort();
            
            File.WriteAllLines(Path.Combine(project.ProjectDirectory, "custom_refs.txt"), list);
        }

        if (!_projectTweakCache.IsEmpty)
        {
            var list = _projectTweakCache.Keys.ToList();
            list.Sort();

            File.WriteAllLines(Path.Combine(project.ProjectDirectory, "custom_tweaks.txt"), list);
        }
    }
}