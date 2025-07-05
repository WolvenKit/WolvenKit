using System.Collections.Generic;
using WolvenKit.RED4.Types;
using Vector3 = SharpDX.Vector3;

namespace WolvenKit.App.Models;

public class SimpleGeometryCacheBuffer
{
    public List<SimpleGeometryCacheEntry> Entries { get; set; } = new();
}

public class SimpleGeometryCacheEntry
{
}

public class SimpleCVXMCacheEntry : SimpleGeometryCacheEntry
{
    public List<Vector3> Vertices { get; set; } = new();
    public List<List<byte>> Faces { get; set; } = new();
    public List<Vector3> FaceData { get; set; } = new();
}

public class SimpleMeshCacheEntry : SimpleGeometryCacheEntry
{
    public List<Vector3> Vertices { get; set; } = new();
    public List<List<ushort>> Faces { get; set; } = new();
}