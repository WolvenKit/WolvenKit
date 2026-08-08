using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.App.Services;

public class HashServiceExt : HashService
{
    /// <summary>
    /// Resettable global caches to avoid gen2 LOH GC.
    /// </summary>
    private ConcurrentDictionary<string, byte> _globalRefCache = new();
    private ConcurrentDictionary<string, byte> _globalTweakCache = new();

    private readonly ConcurrentDictionary<string, byte> _projectRefCache = new();
    private readonly ConcurrentDictionary<string, byte> _projectTweakCache = new();

    private Task _globalCacheLoad = Task.CompletedTask;

    /// <summary>
    /// Completes once <see cref="LoadGlobalCache"/> has finished populating the pools.
    /// </summary>
    public Task GlobalCacheLoaded => _globalCacheLoad;

    /// <summary>
    /// Blocks until the global cache has finished loading. Cheap once complete; this exists so that
    /// moving the load off the UI thread cannot expose a half-populated cache to anything that reads it.
    /// </summary>
    private void WaitForGlobalCache()
    {
        var load = _globalCacheLoad;
        if (!load.IsCompleted)
        {
            load.Wait();
        }
    }

    #region Constructors

    public HashServiceExt() : base(false)
    {
    }

    #endregion Constructors

    /// <summary>
    /// Directory holding the global <c>custom_refs.txt</c> / <c>custom_tweaks.txt</c> caches.
    /// </summary>
    /// <remarks>
    /// Exists purely as a test hook.
    /// Production behaviour is identical.
    /// </remarks>
    protected virtual string GetGlobalCacheDirectory() => ISettingsManager.GetAppData();

    public bool AddResourcePath(string resourcePath)
    {
        WaitForGlobalCache();

        if (ResourcePathPool.IsNative(resourcePath))
        {
            return false;
        }

        _globalRefCache.TryAdd(resourcePath, 0);
        _projectRefCache.TryAdd(resourcePath, 0);

        return true;
    }

    public bool AddTweakName(string tweakName)
    {
        WaitForGlobalCache();

        if (TweakDBIDPool.IsNative(tweakName))
        {
            return false;
        }

        _globalTweakCache.TryAdd(tweakName, 0);
        _projectTweakCache.TryAdd(tweakName, 0);

        return true;
    }

    private void MigrateLegacyGlobalCache(string appData)
    {
        var customRefsFile = Path.Combine(GetGlobalCacheDirectory(), "user_hashes.txt");
        if (!File.Exists(customRefsFile))
        {
            return;
        }

        foreach (var p in File.ReadLines(customRefsFile))
        {
            ResourcePathPool.AddOrGetHash(p);
            _globalRefCache.TryAdd(p, 0);
        }

        File.Delete(customRefsFile);
    }

    /// <summary>
    /// Starts loading the global ref/tweak caches. Returns immediately; await
    /// <see cref="GlobalCacheLoaded"/> to observe completion.
    /// </summary>
    public void LoadGlobalCache() =>
        _globalCacheLoad = Task.Factory.StartNew(LoadGlobalCacheCore, TaskCreationOptions.LongRunning);

    private void LoadGlobalCacheCore()
    {
        var appData = ISettingsManager.GetAppData();
        var customRefsFile = Path.Combine(GetGlobalCacheDirectory(), "custom_refs.txt");
        var customTweaksFile = Path.Combine(appData, "custom_tweaks.txt");

        // Replace rather than Clear() so the dictionaries start at roughly their final size.
        _globalRefCache = new ConcurrentDictionary<string, byte>(
            System.Environment.ProcessorCount, EstimateLineCount(customRefsFile));
        _globalTweakCache = new ConcurrentDictionary<string, byte>(
            System.Environment.ProcessorCount, EstimateLineCount(customTweaksFile));

        MigrateLegacyGlobalCache(appData);

        if (File.Exists(customRefsFile))
        {
            foreach (var p in File.ReadLines(customRefsFile))
            {
                ResourcePathPool.AddOrGetHash(p);
                _globalRefCache.TryAdd(p, 0);
            }
        }

        if (File.Exists(customTweaksFile))
        {
            foreach (var p in File.ReadLines(customTweaksFile))
            {
                TweakDBIDPool.AddOrGetHash(p);
                _globalTweakCache.TryAdd(p, 0);
            }
        }
    }

    /// <summary>Rough capacity hint from file size; over-estimating slightly is far cheaper than re-growing.</summary>
    private static int EstimateLineCount(string path)
    {
        try
        {
            return File.Exists(path) ? (int)System.Math.Clamp(new FileInfo(path).Length / 64, 32, 1 << 21) : 32;
        }
        catch (IOException)
        {
            return 32;
        }
    }

    public void SaveGlobalCache()
    {
        WaitForGlobalCache();

        if (!_globalRefCache.IsEmpty)
        {
            var list = _globalRefCache.Keys.ToList();
            list.Sort();

            File.WriteAllLines(Path.Combine(GetGlobalCacheDirectory(), "custom_refs.txt"), list);
        }

        if (!_globalTweakCache.IsEmpty)
        {
            var list = _globalTweakCache.Keys.ToList();
            list.Sort();

            File.WriteAllLines(Path.Combine(GetGlobalCacheDirectory(), "custom_tweaks.txt"), list);
        }
    }

    private void MigrateLegacyProjectCache(Cp77Project project)
    {
        var customRefsFile = Path.Combine(project.ProjectDirectory, "user_hashes.txt");
        if (File.Exists(customRefsFile))
        {
            foreach (var p in File.ReadLines(customRefsFile))
            {
                ResourcePathPool.AddOrGetHash(p);
                _globalRefCache.TryAdd(p, 0);
            }

            File.Delete(customRefsFile);
        }
    }

    public void LoadProjectCache(Cp77Project project)
    {
        Task.Run(() =>
        {
            var thread = new Thread(() =>
            {
                Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
                Thread.CurrentThread.IsBackground = true;
                WaitForGlobalCache();
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
                    foreach (var p in File.ReadLines(customRefsFile))
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
                    foreach (var p in File.ReadLines(customTweaksFile))
                    {
                        if (AddTweakName(p))
                        {
                            TweakDBIDPool.AddOrGetHash(p);
                        }
                    }
                }
            });

            thread.Start();
            return thread; // Optional: you can wait on the thread if needed
        });
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
