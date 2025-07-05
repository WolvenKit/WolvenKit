using System.Text;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public class CR2WWrapperReader : IBufferReader, IDataCollector, IErrorHandler
{
    private MemoryStream _ms;


    public bool CollectData { get; set; } = false;
    public DataCollection DataCollection { get; } = new();

    public CR2WWrapperReader(MemoryStream ms)
    {
        _ms = ms;
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        using var br = new BinaryReader(_ms, Encoding.Default, true);

        using var reader = new CR2WReader(br);
        reader.ParsingError += HandleParsingError;
        reader.CollectData = CollectData;


        var readResult = reader.ReadFile(out var c, true);
        if (readResult == EFileReadErrorCodes.NoCr2w)
        {
            throw new TodoException("ReadSharedDataBuffer");
        }

        buffer.Data = new CR2WWrapper { File = c! };

        if (reader.CollectData)
        {
            DataCollection.Buffers ??= new List<DataCollection>();
            DataCollection.Buffers.Add(reader.DataCollection);
        }

        return EFileReadErrorCodes.NoError;
    }

    #region ErrorHandler

    public event ParsingErrorEventHandler? ParsingError;
    protected virtual bool HandleParsingError(ParsingErrorEventArgs e) => ParsingError != null && ParsingError.Invoke(e);

    #endregion
}