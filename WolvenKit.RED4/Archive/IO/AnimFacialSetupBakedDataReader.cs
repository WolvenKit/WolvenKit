using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class AnimFacialSetupBakedDataReader : Red4Reader, IBufferReader
{
    public AnimFacialSetupBakedDataReader(Stream input) : base(input)
    {
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not animFacialSetup animFacialSetup)
        {
            return EFileReadErrorCodes.UnsupportedVersion;
        }

        var data = new AnimFacialSetupBakedDataBuffer();

        for (var i = 0; i < animFacialSetup.Info.NumLipsyncOverridesIndexMapping; i++)
        {
            data.LipsyncOverridesIndexMapping.Add(_reader.ReadUInt16());
        }

        for (var i = 0; i < animFacialSetup.Info.NumJointRegions; i++)
        {
            data.JointRegions.Add(_reader.ReadByte());
        }

        data.Face = ReadData(animFacialSetup.Info.Face);
        data.Tongue = ReadData(animFacialSetup.Info.Tongue);
        data.Eyes = ReadData(animFacialSetup.Info.Eyes);

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }

    private FacialSetup_BakedPartData ReadData(animFacialSetup_OneSermoBufferInfo info)
    {
        var data = new FacialSetup_BakedPartData();

        for (var i = 0; i < info.NumEnvelopesPerTrackMapping; i++)
        {
            data.EnvelopesPerTrackMapping.Add(new FacialTrackMapping
            {
                Track = _reader.ReadUInt16(),
                LevelOfDetail = _reader.ReadByte(),
                Envelope = _reader.ReadByte()
            });
        }

        for (var i = 0; i < info.NumGlobalLimits; i++)
        {
            data.GlobalLimits.Add(new FacialPoseLimit
            {
                Max = _reader.ReadSingle(),
                Mid = _reader.ReadSingle(),
                Min = _reader.ReadSingle(),
                Track = _reader.ReadUInt16(),
                Envelope = _reader.ReadByte(),
                IsCachable = _reader.ReadByte() != 0
            });
        }

        for (var i = 0; i < info.NumInfluencedPoses; i++)
        {
            data.InfluencedPoses.Add(new FacialInfluencedPose
            {
                Track = _reader.ReadUInt16(),
                NumInfluences = _reader.ReadByte(),
                Type = _reader.ReadByte()
            });
        }

        for (var i = 0; i < info.NumInfluenceIndices; i++)
        {
            data.InfluenceIndices.Add(_reader.ReadUInt16());
        }

        for (var i = 0; i < info.NumUpperLowerFace; i++)
        {
            data.UpperLowerFace.Add(new FacialParts
            {
                Track = _reader.ReadUInt16(),
                Part = _reader.ReadByte(),
                Unknown = _reader.ReadByte()
            });
        }

        for (var i = 0; i < info.NumLipsyncPosesSides; i++)
        {
            data.LipsyncPosesSides.Add(new FacialPoseSides
            {
                Track = _reader.ReadUInt16(),
                Side = _reader.ReadByte(),
                Unknown = _reader.ReadByte()
            });
        }

        for (var i = 0; i < info.NumGlobalCorrectiveEntries; i++)
        {
            var index = _reader.ReadUInt16();
            var bitwise = _reader.ReadUInt16();

            data.GlobalCorrectiveEntries.Add(new FacialCorrectiveInfo
            {
                Index = index,
                Track = (ushort)((bitwise & 0xFFF0) >> 4),
                Unknown = (byte)(bitwise & 0x000F)
            });
        }

        for (var i = 0; i < info.NumInbetweenCorrectiveEntries; i++)
        {
            var index = _reader.ReadUInt16();
            var bitwise = _reader.ReadUInt16();

            data.InbetweenCorrectiveEntries.Add(new FacialCorrectiveInfo
            {
                Index = index,
                Track = (ushort)((bitwise & 0xFFF0) >> 4),
                Unknown = (byte)(bitwise & 0x000F)
            });
        }

        for (var i = 0; i < info.NumCorrectiveInfluencedPoses; i++)
        {
            data.CorrectiveInfluencedPoses.Add(new FacialCorrectiveInfluencedPose
            {
                Index = _reader.ReadUInt16(),
                NumInfluences = _reader.ReadByte(),
                Type = _reader.ReadByte()
            });
        }

        for (var i = 0; i < info.NumCorrectiveInfluenceIndices; i++)
        {
            data.CorrectiveInfluenceIndices.Add(_reader.ReadUInt16());
        }

        for (var i = 0; i < info.NumAllMainPoses; i++)
        {
            data.AllMainPoses.Add(new FacialMainPoseInfo
            {
                Track = _reader.ReadUInt16(),
                NumInbetweens = _reader.ReadByte(),
                Unknown = _reader.ReadByte()
            });
        }

        for (var i = 0; i < info.NumAllMainPosesInbetweens; i++)
        {
            data.AllMainPosesInbetweens.Add(_reader.ReadSingle());
        }

        for (var i = 0; i < info.NumAllMainPosesInbetweenScopeMultipliers; i++)
        {
            data.AllMainPosesInbetweenScopeMultipliers.Add(_reader.ReadSingle());
        }

        for (var i = 0; i < info.NumWrinkles; i++)
        {
            data.Wrinkles.Add(_reader.ReadUInt16());
        }

        return data;
    }
}