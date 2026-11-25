using System;
using System.Threading;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W;

/// <summary>
/// Keeps textures converted at the same time (Generate Materials, the CLI's uncook, anything run in parallel) within
/// half of the machine's memory. A converted texture lives in native DirectXTex memory the GC doesn't see, so with
/// one thread per core a few big textures at once could take all memory and kill the process without a log line
/// (#3260). Each conversion waits until its estimate fits; one that alone is bigger than the budget still runs,
/// on its own.
/// </summary>
public static class TextureMemoryGate
{
    private static readonly object s_lock = new();
    private static readonly long s_budget = ComputeBudget();
    private static long s_inUse;

    /// <summary>Half of the memory available to the process (physical memory, or the container's limit).</summary>
    public static long Budget => s_budget;

    private static long ComputeBudget()
    {
        var total = GC.GetGCMemoryInfo().TotalAvailableMemoryBytes;
        // unknown: assume 8 GB
        return total > 0 ? total / 2 : 4L * 1024 * 1024 * 1024;
    }

    /// <summary>
    /// What converting a texture takes at most: the decompressed RGBA image with its mips (4/3), plus the
    /// compressed data and the encoded output, taken as three times that.
    /// </summary>
    public static long Estimate(long width, long height, long depth = 1, long slices = 1)
    {
        var pixels = Math.Max(1, width) * Math.Max(1, height) * Math.Max(1, depth) * Math.Max(1, slices);
        return pixels * 4 * 4 / 3 * 3;
    }

    public static long Estimate(CBitmapTexture texture) => Estimate(texture.Width, texture.Height, texture.Depth);

    public static long Estimate(rendRenderTextureBlobPC blob) => Estimate(
        blob.Header.SizeInfo.Width, blob.Header.SizeInfo.Height, blob.Header.SizeInfo.Depth,
        blob.Header.TextureInfo.SliceCount);

    /// <summary>Waits until <paramref name="bytes"/> fit in the budget; dispose the result when the texture is done.</summary>
    public static IDisposable Enter(long bytes)
    {
        bytes = Math.Clamp(bytes, 0, s_budget);
        lock (s_lock)
        {
            while (s_inUse > 0 && s_inUse + bytes > s_budget)
            {
                Monitor.Wait(s_lock);
            }

            s_inUse += bytes;
        }

        return new Lease(bytes);
    }

    private sealed class Lease(long bytes) : IDisposable
    {
        private int _disposed;

        public void Dispose()
        {
            if (Interlocked.Exchange(ref _disposed, 1) != 0)
            {
                return;
            }

            lock (s_lock)
            {
                s_inUse -= bytes;
                Monitor.PulseAll(s_lock);
            }
        }
    }
}
