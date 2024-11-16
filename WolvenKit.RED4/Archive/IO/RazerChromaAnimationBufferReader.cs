using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive.IO;

public class RazerChromaAnimationBufferReader : Red4Reader, IBufferReader
{
    public RazerChromaAnimationBufferReader(Stream input) : base(input)
    {
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var data = new RazerChromaAnimationBuffer();

        data.Version = _reader.ReadUInt32();

        var deviceType = _reader.ReadByte();
        var device = _reader.ReadByte();
        data.Device = RazerChromaHelper.GetDevice(deviceType, device);

        var frameCount = _reader.ReadUInt32();
        for (var i = 0; i < frameCount; i++)
        {
            switch ((EChromaSDKDeviceTypeEnum)deviceType)
            {
                case EChromaSDKDeviceTypeEnum.DE_1D:
                {
                    var info = RazerChromaHelper.GetRowAndColumnCount(data.Device);

                    var frame = new FChromaSDKColorFrame1D();

                    frame.Duration = _reader.ReadSingle();

                    for (var j = 0; j < info.ColumnCount; j++)
                    {
                        frame.Colors.Add(new CColor
                        {
                            Red = _reader.ReadByte(),
                            Green = _reader.ReadByte(),
                            Blue = _reader.ReadByte(),
                            Alpha = 255
                        });

                        _reader.ReadByte(); // always 0
                    }

                    data.Frames.Add(frame);
                    break;
                }
                case EChromaSDKDeviceTypeEnum.DE_2D:
                {
                    var info = RazerChromaHelper.GetRowAndColumnCount(data.Device);

                    var frame = new FChromaSDKColorFrame2D();

                    frame.Duration = _reader.ReadSingle();

                    for (var j = 0; j < info.RowCount; j++)
                    {
                        var colors = new FChromaSDKColors();

                        for (var k = 0; k < info.ColumnCount; k++)
                        {
                            colors.Colors.Add(new CColor
                            {
                                Red = _reader.ReadByte(),
                                Green = _reader.ReadByte(),
                                Blue = _reader.ReadByte(),
                                Alpha = 255
                            });

                            _reader.ReadByte(); // almost always 0, except for sampling/keyboard. There it is always 1
                        }

                        frame.Colors.Add(colors);
                    }

                    data.Frames.Add(frame);
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }
}