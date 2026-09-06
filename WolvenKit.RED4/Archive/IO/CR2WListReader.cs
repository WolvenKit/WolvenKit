using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public class CR2WListReader : IBufferReader, IDataCollector, IErrorHandler
{
    private MemoryStream _ms;

    public bool CollectData { get; set; } = false;
    public DataCollection DataCollection { get; } = new();

    public CR2WListReader(MemoryStream ms)
    {
        _ms = ms;
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var list = new CR2WList();
        
        while (_ms.Position < _ms.Length)
        {
            var reader = new CR2WReader(_ms);
            reader.ParsingError += HandleParsingError;

            reader.CollectData = CollectData;

            if (reader.ReadFile(out var cr2wFile, false) != EFileReadErrorCodes.NoError)
            {
                throw new TodoException("Unexpected error while reading CR2W list!");
            }

            list.Files.Add(cr2wFile);

            if (reader.CollectData)
            {
                DataCollection.Buffers ??= [];
                DataCollection.Buffers.Add(reader.DataCollection);
            }

            _ms = new MemoryStream(_ms.ToArray()[reader.Position..]);
        }

        buffer.Data = list;

        if (buffer.Parent is meshMeshMaterialBuffer mmmb)
        {
            mmmb.Materials = new();
            foreach (var material in list.Files)
            {
                mmmb.Materials.Add(material.RootChunk);
            }
        }

        return EFileReadErrorCodes.NoError;
    }

    #region ErrorHandler

    public event ParsingErrorEventHandler ParsingError;
    protected virtual bool HandleParsingError(ParsingErrorEventArgs e) => ParsingError != null && ParsingError.Invoke(e);

    #endregion
}
