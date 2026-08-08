using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.App.Services;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;
using Xunit;

namespace WolvenKit.IntegrationTests.App.Services;

/// <summary>
/// Covers <see cref="HashServiceExt"/>'s global ref/tweak cache loading against a throwaway
/// directory.
///
/// These deliberately never touch the real <c>%APPDATA%\REDModding\WolvenKit</c>.
/// <see cref="TestHashServiceExt"/> overrides the directory
/// so a test physically cannot reach the developer's own <c>custom_refs.txt</c>.
/// </summary>
[Collection(nameof(RedTypePoolCollection))]
public sealed class HashServiceExtGlobalCacheTests : IDisposable
{
    /// <summary>Redirects only the global cache directory; everything else is the real service.</summary>
    private sealed class TestHashServiceExt : HashServiceExt
    {
        private readonly string _directory;

        public TestHashServiceExt(string directory) => _directory = directory;

        protected override string GetGlobalCacheDirectory() => _directory;
    }

    private readonly string _directory;

    public HashServiceExtGlobalCacheTests()
    {
        _directory = Path.Combine(Path.GetTempPath(), "wk-globalcache-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_directory);
    }

    public void Dispose()
    {
        try
        {
            Directory.Delete(_directory, true);
        }
        catch (IOException)
        {
            // a leaked temp directory must never fail a test run
        }
    }

    private string RefsPath => Path.Combine(_directory, "custom_refs.txt");

    private string TweaksPath => Path.Combine(_directory, "custom_tweaks.txt");

    private string LegacyRefsPath => Path.Combine(_directory, "user_hashes.txt");

    private HashServiceExt NewService() => new TestHashServiceExt(_directory);

    /// <summary>Loads, saves, and returns what actually landed on disk.</summary>
    private (List<string> Refs, List<string> Tweaks) RoundTrip()
    {
        var service = NewService();
        service.LoadGlobalCache();
        service.SaveGlobalCache();

        return (ReadAllLinesOrEmpty(RefsPath), ReadAllLinesOrEmpty(TweaksPath));
    }

    private static List<string> ReadAllLinesOrEmpty(string path) =>
        File.Exists(path) ? File.ReadAllLines(path).ToList() : new List<string>();

    /// <summary>Mirrors the production ordering, which is List&lt;string&gt;.Sort() - culture-sensitive.</summary>
    private static List<string> ProductionSorted(IEnumerable<string> values)
    {
        var list = values.Distinct().ToList();
        list.Sort();
        return list;
    }

    [Fact]
    public void LoadGlobalCache_WithNoFilesPresent_DoesNothing()
    {
        var service = NewService();

        service.LoadGlobalCache();
        service.SaveGlobalCache();

        // an empty cache must not create files, or every launch would litter the data directory
        Assert.False(File.Exists(RefsPath));
        Assert.False(File.Exists(TweaksPath));
    }

    [Fact]
    public void LoadGlobalCache_ReadsCustomRefs()
    {
        var paths = new[]
        {
            @"globalcachetest\alpha\one.mesh",
            @"globalcachetest\beta\two.mesh",
            @"globalcachetest\gamma\three.ent",
        };
        File.WriteAllLines(RefsPath, paths);

        var (refs, _) = RoundTrip();

        Assert.Equal(ProductionSorted(paths), refs);
    }

    [Fact]
    public void LoadGlobalCache_ReadsCustomTweaks()
    {
        var names = new[]
        {
            "GlobalCacheTest.Alpha",
            "GlobalCacheTest.Beta",
        };
        File.WriteAllLines(TweaksPath, names);

        var (_, tweaks) = RoundTrip();

        Assert.Equal(ProductionSorted(names), tweaks);
    }

    [Fact]
    public void LoadGlobalCache_ReadsBothFilesIndependently()
    {
        File.WriteAllLines(RefsPath, new[] { @"globalcachetest\both\ref.mesh" });
        File.WriteAllLines(TweaksPath, new[] { "GlobalCacheTest.Both" });

        var (refs, tweaks) = RoundTrip();

        Assert.Equal(new[] { @"globalcachetest\both\ref.mesh" }, refs);
        Assert.Equal(new[] { "GlobalCacheTest.Both" }, tweaks);
    }

    [Fact]
    public void LoadGlobalCache_DeduplicatesRepeatedEntries()
    {
        const string duplicated = @"globalcachetest\dupe\entry.mesh";
        File.WriteAllLines(RefsPath, new[] { duplicated, duplicated, duplicated });

        var (refs, _) = RoundTrip();

        Assert.Equal(new[] { duplicated }, refs);
    }

    [Fact]
    public void LoadGlobalCache_PreservesRawTextRatherThanSanitizing()
    {
        // the cache stores the line as written; only the pool hash is sanitized
        const string unsanitized = @"GLOBALCACHETEST/RAW//ENTRY.MESH";
        File.WriteAllLines(RefsPath, new[] { unsanitized });

        var (refs, _) = RoundTrip();

        Assert.Equal(new[] { unsanitized }, refs);
    }

    [Fact]
    public void LoadGlobalCache_SurvivesBlankAndWhitespaceLines()
    {
        File.WriteAllLines(RefsPath, new[] { @"globalcachetest\blank\a.mesh", "", "   ", @"globalcachetest\blank\b.mesh" });

        var (refs, _) = RoundTrip();

        Assert.Contains(@"globalcachetest\blank\a.mesh", refs);
        Assert.Contains(@"globalcachetest\blank\b.mesh", refs);
    }

    [Fact]
    public void LoadGlobalCache_HandlesCrLfAndLfLineEndings()
    {
        File.WriteAllText(RefsPath, "globalcachetest\\eol\\crlf.mesh\r\nglobalcachetest\\eol\\lf.mesh\n");

        var (refs, _) = RoundTrip();

        Assert.Contains(@"globalcachetest\eol\crlf.mesh", refs);
        Assert.Contains(@"globalcachetest\eol\lf.mesh", refs);
    }

    [Fact]
    public void LoadGlobalCache_HandlesNonAsciiEntries()
    {
        var paths = new[] { @"globalcachetest\ünïcödé\file.mesh", @"globalcachetest\日本語\file.mesh" };
        File.WriteAllLines(RefsPath, paths);

        var (refs, _) = RoundTrip();

        Assert.Equal(ProductionSorted(paths), refs);
    }

    [Fact]
    public void SaveGlobalCache_WritesSortedOutput()
    {
        var paths = new[]
        {
            @"globalcachetest\sort\zulu.mesh",
            @"globalcachetest\sort\alpha.mesh",
            @"globalcachetest\sort\mike.mesh",
        };
        File.WriteAllLines(RefsPath, paths);

        var (refs, _) = RoundTrip();

        Assert.Equal(ProductionSorted(paths), refs);
    }

    [Fact]
    public void LoadGlobalCache_MigratesLegacyUserHashesFile()
    {
        const string legacy = @"globalcachetest\legacy\migrated.mesh";
        File.WriteAllLines(LegacyRefsPath, new[] { legacy });

        var (refs, _) = RoundTrip();

        Assert.Contains(legacy, refs);

        // the legacy file is consumed, so migration cannot run twice
        Assert.False(File.Exists(LegacyRefsPath));
    }

    [Fact]
    public void LoadGlobalCache_MergesLegacyAndCurrentRefs()
    {
        const string legacy = @"globalcachetest\merge\legacy.mesh";
        const string current = @"globalcachetest\merge\current.mesh";

        File.WriteAllLines(LegacyRefsPath, new[] { legacy });
        File.WriteAllLines(RefsPath, new[] { current });

        var (refs, _) = RoundTrip();

        Assert.Contains(legacy, refs);
        Assert.Contains(current, refs);
        Assert.False(File.Exists(LegacyRefsPath));
    }

    [Fact]
    public void LoadGlobalCache_ReplacesPreviousContentsOnReload()
    {
        var service = NewService();

        File.WriteAllLines(RefsPath, new[] { @"globalcachetest\reload\first.mesh" });
        service.LoadGlobalCache();

        File.WriteAllLines(RefsPath, new[] { @"globalcachetest\reload\second.mesh" });
        service.LoadGlobalCache();
        service.SaveGlobalCache();

        var refs = ReadAllLinesOrEmpty(RefsPath);

        // LoadGlobalCache clears before repopulating, so the first entry must be gone
        Assert.Equal(new[] { @"globalcachetest\reload\second.mesh" }, refs);
    }

    [Fact]
    public void LoadGlobalCache_IsStableAcrossRepeatedRoundTrips()
    {
        var paths = new[] { @"globalcachetest\stable\a.mesh", @"globalcachetest\stable\b.mesh" };
        File.WriteAllLines(RefsPath, paths);

        var first = RoundTrip().Refs;
        var second = RoundTrip().Refs;
        var third = RoundTrip().Refs;

        Assert.Equal(first, second);
        Assert.Equal(second, third);
    }

    [Fact]
    public void LoadGlobalCache_RegistersEntriesWithTheResourcePathPool()
    {
        // deliberately unsanitized: the pool must key off the sanitized form
        const string raw = @"GLOBALCACHETEST/POOL//REGISTERED.MESH";
        File.WriteAllLines(RefsPath, new[] { raw });

        var service = NewService();
        service.LoadGlobalCache();

        var sanitized = ResourcePath.SanitizePath(raw);
        var hash = ResourcePath.CalculateHash(sanitized, false);

        Assert.Equal(sanitized, ResourcePathPool.ResolveHash(hash));
    }

    [Fact]
    public void LoadGlobalCache_RegistersEntriesWithTheTweakDbIdPool()
    {
        const string name = "GlobalCacheTest.PoolRegistered";
        File.WriteAllLines(TweaksPath, new[] { name });

        var service = NewService();
        service.LoadGlobalCache();

        Assert.Equal(name, TweakDBIDPool.ResolveHash(TweakDBID.CalculateHash(name)));
    }

    [Fact]
    public void SaveGlobalCache_WithoutLoad_DoesNotCreateFiles()
    {
        var service = NewService();

        service.SaveGlobalCache();

        Assert.False(File.Exists(RefsPath));
        Assert.False(File.Exists(TweaksPath));
    }

    [Fact]
    public void GlobalCacheDirectory_IsRedirected_SoRealAppDataIsNeverTouched()
    {
        // The guard for every other test here: if the seam were not in effect, the write below would
        // land in the developer's real %APPDATA% instead of the temp directory.
        File.WriteAllLines(RefsPath, new[] { @"globalcachetest\seam\proof.mesh" });

        var service = NewService();
        service.LoadGlobalCache();
        service.SaveGlobalCache();

        Assert.True(File.Exists(RefsPath));
        Assert.Contains(@"globalcachetest\seam\proof.mesh", File.ReadAllLines(RefsPath));

        var realAppData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "REDModding", "WolvenKit");

        Assert.False(string.Equals(_directory, realAppData, StringComparison.OrdinalIgnoreCase));
    }
}

/// <summary>
/// Serializes tests that mutate the process-wide RED4 type pools.
/// Otherwise these tests will mess with each others' caches and get messed up.
/// </summary>
[CollectionDefinition(nameof(RedTypePoolCollection), DisableParallelization = true)]
public class RedTypePoolCollection;
