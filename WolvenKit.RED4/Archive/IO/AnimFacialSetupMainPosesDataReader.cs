using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class AnimFacialSetupMainPosesDataReader : Red4Reader, IBufferReader
{
    public AnimFacialSetupMainPosesDataReader(Stream input) : base(input)
    {
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not animFacialSetup animFacialSetup)
        {
            return EFileReadErrorCodes.UnsupportedVersion;
        }

        buffer.Data = new AnimFacialSetupPosesDataBuffer
        {
            Face = ReadData(animFacialSetup.PosesInfo.Face),
            Tongue = ReadData(animFacialSetup.PosesInfo.Tongue),
            Eyes = ReadData(animFacialSetup.PosesInfo.Eyes)
        };

        return EFileReadErrorCodes.NoError;
    }

    private AnimFacialSetupPosesPartData ReadData(animFacialSetup_OneSermoPoseBufferInfo info)
    {
        var data = new AnimFacialSetupPosesPartData();

        for (var i = 0; i < info.NumMainPoses; i++)
        {
            var poseTrackInfo = new FacialSetup_PoseTrackInfo
            {
                TransformIdx = _reader.ReadInt32(),
                ScaleIdx = _reader.ReadInt32()
            };

            var bitwise = _reader.ReadUInt16();
            poseTrackInfo.NumTransforms = bitwise & 0x7FFF;
            poseTrackInfo.IsScale = (bitwise & 0x8000) != 0;

            poseTrackInfo.Flag1 = _reader.ReadUInt16();
            poseTrackInfo.Flag2 = _reader.ReadUInt16();
            poseTrackInfo.Flag3 = _reader.ReadUInt16();

            data.Poses.Add(poseTrackInfo);
        }

        for (var i = 0; i < info.NumMainTransforms; i++)
        {
            data.Transforms.Add(new FacialTransform
            {
                Rotation = new Quaternion
                {
                    I = _reader.ReadSingle(),
                    J = _reader.ReadSingle(),
                    K = _reader.ReadSingle(),
                    R = _reader.ReadSingle(),
                },
                Translation = new Vector3
                {
                    X = _reader.ReadSingle(),
                    Y = _reader.ReadSingle(),
                    Z = _reader.ReadSingle(),
                },
                Bone = _reader.ReadUInt16(),
                JointRegion = _reader.ReadByte(),
                Unknown = _reader.ReadByte()
            });
        }

        for (var i = 0; i < info.NumMainScales; i++)
        {
            data.Scales.Add(new Quaternion
            {
                I = _reader.ReadSingle(),
                J = _reader.ReadSingle(),
                K = _reader.ReadSingle(),
                R = _reader.ReadSingle(),
            });
        }

        return data;
    }
}