using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace WolvenKit.Core.Unmanaged;

public struct UnmanagedMemory : IDisposable
{
    private readonly int _bufferSize;
    private readonly IntPtr _address;
    private readonly Lazy<UnmanagedMemoryStream> _lazyStream;
    
    private long _disposed = 0;

    public unsafe UnmanagedMemory(int bufferSize)
    {
        var address = Marshal.AllocHGlobal(bufferSize);
        
        _bufferSize = bufferSize;
        _address = address;
        _lazyStream = new Lazy<UnmanagedMemoryStream>(() => new UnmanagedMemoryStream((byte*) address.ToPointer(), bufferSize));
    }

    public unsafe byte* Pointer => (byte*)_address.ToPointer();
    public int Size => _bufferSize;
    public unsafe Span<byte> GetSpan() => new(Pointer, Size);
    
    public UnmanagedMemoryStream GetStream() => _lazyStream.Value;

    public void Dispose()
    {
        if(Interlocked.Read(ref _disposed) != 0)
            return;
        
        Interlocked.Increment(ref _disposed);
        
        if(_lazyStream.IsValueCreated)
            _lazyStream.Value.Dispose();
        
        Marshal.FreeHGlobal(_address);
    }

    public static UnmanagedMemory Allocate(int bufferSize) => new(bufferSize);
}