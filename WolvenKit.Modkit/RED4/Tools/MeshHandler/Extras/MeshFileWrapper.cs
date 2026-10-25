using System;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

public class MeshFileWrapper
{
    private readonly CR2WFile _file;

    public CMesh CMesh => _file.RootChunk as CMesh ?? throw new InvalidOperationException();
    public rendRenderMeshBlob RendBlob => CMesh.RenderResourceBlob.Chunk as rendRenderMeshBlob ?? throw new InvalidOperationException();
    public rendRenderMeshBlobHeader Header => RendBlob.Header;

    private MeshFileWrapper(CR2WFile file)
    {
        _file = file;
    }

    public CR2WFile GetFile() => _file;

    public static MeshFileWrapper Create()
    {
        var file = new CR2WFile
        {
            RootChunk = new CMesh
            {
                RenderResourceBlob = new CHandle<IRenderResourceBlob>(new rendRenderMeshBlob())
            }
        };

        return new MeshFileWrapper(file);
    }

    public static MeshFileWrapper? Create(CR2WFile file)
    {
        if (file.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendBlob } cMesh)
        {
            return null;
        }

        return new MeshFileWrapper(file);
    }
}
