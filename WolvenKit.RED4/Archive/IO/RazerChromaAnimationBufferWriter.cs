using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Archive.IO;

public class RazerChromaAnimationBufferWriter : Red4Writer
{
    public RazerChromaAnimationBufferWriter(Stream ms) : base(ms)
    {

    }

    public void WriteBuffer(RazerChromaAnimationBuffer data)
    {
        _writer.Write(data.Version);

        var (deviceType, device) = RazerChromaHelper.GetDeviceInfo(data.Device);
        _writer.Write(deviceType);
        _writer.Write(device);

        var info = RazerChromaHelper.GetRowAndColumnCount(data.Device);

        _writer.Write(data.Frames.Count);
        foreach (var frame in data.Frames)
        {
            if (frame is FChromaSDKColorFrame1D frame1D)
            {
                if (info.RowCount != 1 || info.ColumnCount != frame1D.Colors.Count)
                {
                    throw new InvalidOperationException();
                }

                _writer.Write(frame1D.Duration);

                foreach (var color in frame1D.Colors)
                {
                    _writer.Write(color.Red);
                    _writer.Write(color.Green);
                    _writer.Write(color.Blue);
                    _writer.Write((byte)0);
                }
            }
            else if (frame is FChromaSDKColorFrame2D frame2D)
            {
                if (info.RowCount != frame2D.Colors.Count)
                {
                    throw new InvalidOperationException();
                }

                _writer.Write(frame2D.Duration);

                foreach (var row in frame2D.Colors)
                {
                    if (info.ColumnCount != row.Colors.Count)
                    {
                        throw new InvalidOperationException();
                    }

                    foreach (var color in row.Colors)
                    {
                        _writer.Write(color.Red);
                        _writer.Write(color.Green);
                        _writer.Write(color.Blue);
                        _writer.Write((byte)0);
                    }
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}