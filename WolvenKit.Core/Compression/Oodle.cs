using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Core.Compression;

public static class Oodle
{
    public enum Compressor : int
    {
        LZH = 0,
        LZHLW = 1,
        LZNIB = 2,
        None = 3,
        LZB16 = 4,
        LZBLW = 5,
        LZA = 6,
        LZNA = 7,
        Kraken = 8,
        Mermaid = 9,
        BitKnit = 10,
        Selkie = 11,
        Akkorokamui = 12,
    }

    public enum CompressionLevel
    {
        None = 0,
        SuperFast = 1,
        VeryFast = 2,
        Fast = 3,
        Normal = 4,
        Optimal1 = 5,
        Optimal2 = 6,
        Optimal3 = 7,
        Optimal4 = 8,
        Optimal5 = 9,
    }

    public enum FuzzSafe
    {
        No = 0,
        Yes = 1
    }

    public enum CheckCRC
    {
        No = 0,
        Yes = 1
    }

    public enum Verbosity
    {
        None = 0,
        Minimal = 1,
        Some = 2,
        Lots = 3
    }

    public enum ThreadPhase
    {
        ThreadPhase1 = 1,
        ThreadPhase2 = 2,
        ThreadPhaseAll = 3,
        Unthreaded = ThreadPhaseAll
    }

    public enum Status
    {
        Uncompressed,
        Compressed
    }

    public const uint KARK = 1263681867; // 0x4b, 0x41, 0x52, 0x4b

    public static bool Load(string? filePath = null)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // try get oodle dll from game
            if (TryCopyOodleLib(filePath))
            {
                var result = OodleLib.Load(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.Oodle));
                if (result)
                {
                    CompressionSettings.Get().CompressionLevel = CompressionLevel.Optimal2;
                    CompressionSettings.Get().UseOodle = true;
                    return true;
                }
            }

            return true;
        }

        return RuntimeInformation.IsOSPlatform(OSPlatform.OSX) || (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? true : throw new NotImplementedException());
    }

    public static bool IsCompressed(byte[] buf) => buf.Length >= 4 && buf[0] == 0x4B && buf[1] == 0x41 && buf[2] == 0x52 && buf[3] == 0x4B;
    public static bool IsCompressed(Stream stream) => stream.PeekFourCC() == 0x4B52414B;

    public static Status CompressBuffer(byte[] rawBuf, out byte[] compBuf, bool forceCompression) => CompressBuffer(rawBuf, out compBuf, CompressionSettings.Get().CompressionLevel, forceCompression);

    public static Status CompressBuffer(byte[] rawBuf, out byte[] compBuf, CompressionLevel compressionLevel, bool forceCompression)
    {
        ArgumentNullException.ThrowIfNull(rawBuf);
        ArgumentOutOfRangeException.ThrowIfZero(rawBuf.Length, nameof(rawBuf));

        if (!forceCompression && rawBuf.Length <= 256)
        {
            compBuf = rawBuf;
            return Status.Uncompressed;
        }

        var maxCompressedSize = GetCompressedBufferSizeNeeded(rawBuf.Length);
        byte[] compressedBuffer;
        int compressedOffset;

        if (forceCompression && rawBuf.Length <= 256)
        {
            compressedBuffer = new byte[maxCompressedSize + 10];
            compressedOffset = 10;
            Array.Copy(BitConverter.GetBytes(KARK), 0, compressedBuffer, 0, 4);
            Array.Copy(BitConverter.GetBytes(rawBuf.Length), 0, compressedBuffer, 4, 4);
            Array.Copy(new byte[] { 0xCC, 0x06 }, 0, compressedBuffer, 8, 2);
        }
        else
        {
            compressedBuffer = new byte[maxCompressedSize + 8];
            compressedOffset = 8;
            Array.Copy(BitConverter.GetBytes(KARK), 0, compressedBuffer, 0, 4);
            Array.Copy(BitConverter.GetBytes(rawBuf.Length), 0, compressedBuffer, 4, 4);
        }

        var realSize = CallCompress(rawBuf, compressedBuffer, compressedOffset, compressionLevel);

        if (forceCompression || rawBuf.Length > compressedBuffer.Length)
        {
            compBuf = new byte[realSize + compressedOffset];
            Array.Copy(compressedBuffer, 0, compBuf, 0, realSize + compressedOffset);
            return Status.Compressed;
        }

        compBuf = rawBuf;
        return Status.Uncompressed;
    }

    public static bool DecompressBuffer(byte[] compBuf, out byte[] rawBuf)
    {
        using var ms = new MemoryStream(compBuf);
        return DecompressBuffer(ms, out rawBuf);
    }

    public static bool DecompressBuffer(Stream inStream, out byte[] rawBuf)
    {
        if (inStream is not { CanRead: true })
        {
            throw new ArgumentException(nameof(inStream));
        }

        var header = inStream.ReadStruct<uint>();
        if (header == KARK)
        {
            var size = inStream.ReadStruct<uint>();

            var compressedData = new byte[inStream.Length - 8];
            inStream.Read(compressedData, 0, compressedData.Length);
            rawBuf = new byte[size];

            Decompress(compressedData, rawBuf);
            return true;
        }

        rawBuf = Array.Empty<byte>();
        return false;
    }

    public static int Compress(byte[] inputBuffer, out byte[] outputBuffer, bool useRedHeader,
        CompressionLevel level = CompressionLevel.Normal, Compressor compressor = Compressor.Kraken)
    {
        ArgumentNullException.ThrowIfNull(inputBuffer);
        ArgumentOutOfRangeException.ThrowIfZero(inputBuffer.Length, nameof(inputBuffer));

        var maxCompressedSize = GetCompressedBufferSizeNeeded(inputBuffer.Length);
        byte[] compressedBuffer;
        var compressedOffset = 0;

        if (useRedHeader)
        {
            compressedBuffer = new byte[maxCompressedSize + 8];
            compressedOffset = 8;
            Array.Copy(BitConverter.GetBytes(KARK), 0, compressedBuffer, 0, 4);
            Array.Copy(BitConverter.GetBytes(inputBuffer.Length), 0, compressedBuffer, 4, 4);
        }
        else
        {
            compressedBuffer = new byte[maxCompressedSize];
        }

        var realSize = CallCompress(inputBuffer, compressedBuffer, compressedOffset, level, compressor);

        // should it really always be counting the header? It was like this before I touched it,
        // so I'll leave it as it is for now
        if (realSize != 0 && inputBuffer.Length > (realSize + 8))
        {
            outputBuffer = new byte[realSize + compressedOffset];
            Array.Copy(compressedBuffer, 0, outputBuffer, 0, realSize + compressedOffset);
            return outputBuffer.Length;
        }

        outputBuffer = inputBuffer;
        return inputBuffer.Length;
    }

    /// <summary>
    /// Compresses a buffer using the Kraken or Oodle library depending on the OS.
    /// Caller should validate input.
    /// </summary>
    /// <param name="inputBuffer"></param>
    /// <param name="outputBuffer"></param>
    /// <param name="outputBufferOffset"></param>
    /// <param name="level"></param>
    /// <param name="compressor"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private static unsafe int CallCompress(byte[] inputBuffer, byte[] outputBuffer, int outputBufferOffset,
        CompressionLevel level = CompressionLevel.Normal, Compressor compressor = Compressor.Kraken)
    {
        int res;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && CompressionSettings.Get().UseOodle)
        {
            fixed (byte* inPtr = &inputBuffer[0])
            fixed (byte* outPtr = &outputBuffer[outputBufferOffset])
            {
                res = OodleLib.OodleLZ_Compress(inPtr, inputBuffer.Length, outPtr, compressor, level);
            }
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ||
                 RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                 RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            fixed (byte* inPtr = &inputBuffer[0])
            fixed (byte* outPtr = &outputBuffer[outputBufferOffset])
            {
                res = KrakenNative.Compress(inPtr, inputBuffer.Length, outPtr, (int)level);
            }
        }
        else
        {
            throw new NotImplementedException();
        }
        return res;
    }


    public static long Decompress(byte[] inputBuffer, byte[] outputBuffer)
    {
        int result;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            result = CompressionSettings.Get().UseOodle
                ? OodleLib.OodleLZ_Decompress(inputBuffer, outputBuffer)
                : KrakenNative.Decompress(inputBuffer, outputBuffer);
        }
        else
        {
            result = RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                ? KrakenNative.Decompress(inputBuffer, outputBuffer)
                : RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                            ? KrakenNative.Decompress(inputBuffer, outputBuffer)
                            : throw new NotImplementedException();
        }

        return result;
    }

    public static unsafe long Decompress(byte* inputBuffer, long inputBufferSize, byte* outputBuffer, long outputBufferSize)
    {
        int result;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            result = CompressionSettings.Get().UseOodle
                ? OodleLib.OodleLZ_Decompress(inputBuffer, inputBufferSize, outputBuffer, outputBufferSize)
                : KrakenNative.Decompress(inputBuffer, inputBufferSize, outputBuffer, outputBufferSize);
        }
        else
        {
            result = RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                ? KrakenNative.Decompress(inputBuffer, inputBufferSize, outputBuffer, outputBufferSize)
                : RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                    ? KrakenNative.Decompress(inputBuffer, inputBufferSize, outputBuffer, outputBufferSize)
                    : throw new NotImplementedException();
        }

        return result;
    }

    /// <summary>
    /// Decompresses and copies a segment of zsize bytes from a stream to another stream
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="outStream"></param>
    /// <param name="zSize"></param>
    /// <param name="size"></param>
    /// <exception cref="DecompressionException"></exception>
    public static void DecompressAndCopySegment(this Stream stream, Stream outStream, uint zSize, uint size)
    {
        if (zSize == size)
        {
            stream.CopyToWithLength(outStream, (int)zSize);
        }
        else
        {
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression == KARK)
            {
                var headerSize = stream.ReadStruct<uint>();
                if (headerSize != size)
                {
                    // don't throw but use the KARK header size
                    //throw new DecompressionException($"Buffer size doesn't match size in info table. {headerSize} vs {size}");
                    size = headerSize;
                }

                //const int SPAN_LEN = 5333;//32768;
                var length = (int)zSize - 8;

                var inputBuffer = new byte[length];
                var read = stream.Read(inputBuffer);
                var outBuffer = new byte[size];
                var unpackedSize = Oodle.Decompress(inputBuffer, outBuffer);

                //var inputBufferSpan = length <= SPAN_LEN
                //    ? stackalloc byte[length]
                //    : new byte[length];
                //var outputBufferSpan = size <= SPAN_LEN ? stackalloc byte[(int)size] : new byte[size];

                //stream.Read(inputBufferSpan);

                //var unpackedSize = Oodle.Decompress(inputBufferSpan, outputBufferSpan);
                if (unpackedSize != size)
                {
                    throw new DecompressionException($"Unpacked size {unpackedSize} doesn't match real size {size}.");
                }

                //outStream.Write(outputBufferSpan);
                outStream.Write(outBuffer);
            }
            else
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyToWithLength(outStream, (int)zSize);
            }
        }
    }

    /// <summary>
    /// Decompresses and copies a segment of zsize bytes from a stream to another stream
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="outStream"></param>
    /// <param name="zSize"></param>
    /// <param name="size"></param>
    /// <exception cref="Exception"></exception>
    /// <exception cref="DecompressionException"></exception>
    public static async Task DecompressAndCopySegmentAsync(this Stream stream, Stream outStream, uint zSize, uint size)
    {
        if (zSize == size)
        {
            stream.CopyToWithLength(outStream, (int)zSize);
        }
        else
        {
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression == KARK)
            {
                var headerSize = stream.ReadStruct<uint>();
                if (headerSize != size)
                {
                    // don't throw but use the KARK header size
                    // throw new DecompressionException($"Buffer size doesn't match size in info table. {headerSize} vs {size}");
                    size = headerSize;
                }

                var inputBuffer = new byte[(int)zSize - 8];

                var read = stream.Read(inputBuffer);
                var outputBuffer = new byte[size];

                var unpackedSize = await Task.Run(() => Oodle.Decompress(inputBuffer, outputBuffer));

                if (unpackedSize != size)
                {
                    throw new DecompressionException($"Unpacked size {unpackedSize} doesn't match real size {size}.");
                }

                outStream.Write(outputBuffer);
            }
            else
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyToWithLength(outStream, (int)zSize);
            }
        }
    }

    /// <summary>
    /// Gets the max buffer size needed for oodle compression
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public static int GetCompressedBufferSizeNeeded(int count)
    {
        var n = (((count + 0x3ffff + ((uint)((count + 0x3ffff) >> 0x1f) & 0x3ffff)) >> 0x12) * 0x112) + count;
        //var n  = OodleNative.GetCompressedBufferSizeNeeded((long)count);
        return (int)n;
    }

    private static bool TryCopyOodleLib(string? filePath)
    {
        var localData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        var destFileName = Path.Combine(localData, Constants.Oodle);
        if (File.Exists(destFileName))
        {
            return true;
        }

        if (File.Exists(filePath) && filePath.Contains(Constants.Oodle))
        {
            File.Copy(filePath, destFileName);
            return true;
        }

        var cp77BinDir = "";
        try
        {
            cp77BinDir = TryGetGameInstallDir();
        }
        catch (Exception)
        {
            // just swallow this
        }

        if (string.IsNullOrEmpty(cp77BinDir))
        {
            return false;
        }

        // copy oodle dll
        var oodleInfo = new FileInfo(Path.Combine(cp77BinDir, Constants.Oodle));
        if (!oodleInfo.Exists)
        {
            return false;
        }

        if (!File.Exists(destFileName))
        {
            oodleInfo.CopyTo(destFileName);
        }

        return true;
    }

    private delegate void StrDelegate(string value);

    private static string TryGetGameInstallDir()
    {
        var cp77BinDir = "";

#pragma warning disable CA1416
#if _WINDOWS
        var cp77exe = "";
        // check for CP77_DIR environment variable first
        var CP77_DIR = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
        if (!string.IsNullOrEmpty(CP77_DIR) && new DirectoryInfo(CP77_DIR).Exists)
        {
            cp77BinDir = Path.Combine(CP77_DIR, "bin", "x64");
        }

        if (File.Exists(Path.Combine(cp77BinDir, "Cyberpunk2077.exe")))
        {
            return cp77BinDir;
        }

        // else: look for install location
        const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
        const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
        const string gameName = "Cyberpunk 2077";
        const string exeName = "Cyberpunk2077.exe";
        var exePath = "";
        void strDelegate(string msg) => cp77exe = msg;

        try
        {
            var subkeys = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames();
            if (subkeys is not null)
            {
                Parallel.ForEach(subkeys, item =>
                {
                    var programName = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey + item)?.GetValue("DisplayName");
                    var installLocation = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey + item)?.GetValue("InstallLocation");
                    if (programName?.ToString() is string n && installLocation?.ToString() is string l && n.Contains(gameName))
                    {
                        exePath = Directory.GetFiles(l, exeName, SearchOption.AllDirectories).First();
                    }

                    strDelegate(exePath);
                });
            }

            var uninstallkeys = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames();
            if (uninstallkeys is not null)
            {
                Parallel.ForEach(uninstallkeys, item =>
                {
                    var programName = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)?.GetValue("DisplayName");
                    var installLocation = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)?.GetValue("InstallLocation");
                    if (programName?.ToString() is string n && installLocation?.ToString() is string l)
                    {
                        if (n.Contains(gameName) || n.Contains(gameName))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                            {
                                exePath = Directory.GetFiles(l, exeName, SearchOption.AllDirectories).First();
                            }
                        }
                    }

                    strDelegate(exePath);
                });
            }

            var fi = new FileInfo(cp77exe);
            if (fi is not null && fi.Exists && fi.Directory is not null)
            {
                cp77BinDir = fi.Directory.FullName;
            }
        }
        catch (Exception)
        {
            return "";
        }

        if (string.IsNullOrEmpty(cp77BinDir))
        {
            return "";
        }

        if (!File.Exists(Path.Combine(cp77BinDir, "Cyberpunk2077.exe")))
        {
            return "";
        }
#endif
#pragma warning restore CA1416

        return cp77BinDir;
    }

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="path"></param>
    /// <param name="outpath"></param>
    /// <param name="decompress"></param>
    /// <param name="compress"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int OodleTask(string path, string outpath, bool decompress, bool compress)
    {
        if (string.IsNullOrEmpty(path))
        {
            return 0;
        }

        if (string.IsNullOrEmpty(outpath))
        {
            outpath = Path.ChangeExtension(path, ".kark");
        }

        if (decompress)
        {
            var file = File.ReadAllBytes(path);
            using var ms = new MemoryStream(file);
            using var br = new BinaryReader(ms);

            var oodleCompression = br.ReadBytes(4);
            if (!oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b }))
            {
                throw new NotImplementedException();
            }

            var size = br.ReadUInt32();

            var buffer = br.ReadBytes(file.Length - 8);

            var unpacked = new byte[size];
            var unpackedSize = Oodle.Decompress(buffer, unpacked);

            using var msout = new MemoryStream();
            using var bw = new BinaryWriter(msout);
            bw.Write(unpacked);

            File.WriteAllBytes($"{outpath}", msout.ToArray());
        }

        if (compress)
        {
            var inbuffer = File.ReadAllBytes(path);
            var r = Oodle.Compress(inbuffer, out var outBuffer, true);

            File.WriteAllBytes(outpath, outBuffer);
        }

        return 1;
    }

}
