using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class AnimFacialSetupBakedDataWriter : Red4Writer
{
    public AnimFacialSetupBakedDataWriter(Stream ms) : base(ms)
    {

    }

    public void WriteBuffer(AnimFacialSetupBakedDataBuffer buffer, animFacialSetup animFacialSetup)
    {
        animFacialSetup.Info.NumLipsyncOverridesIndexMapping = (CUInt16)buffer.LipsyncOverridesIndexMapping.Count;
        foreach (var val in buffer.LipsyncOverridesIndexMapping)
        {
            Write(val);
        }

        animFacialSetup.Info.NumJointRegions = (CUInt16)buffer.JointRegions.Count;
        foreach (var val in buffer.JointRegions)
        {
            Write(val);
        }

        WriteBakedPartData(buffer.Face, animFacialSetup.Info.Face);
        WriteBakedPartData(buffer.Tongue, animFacialSetup.Info.Tongue);
        WriteBakedPartData(buffer.Eyes, animFacialSetup.Info.Eyes);
    }

    private void WriteBakedPartData(FacialSetup_BakedPartData data, animFacialSetup_OneSermoBufferInfo info)
    {
        info.NumEnvelopesPerTrackMapping = (CUInt16)data.EnvelopesPerTrackMapping.Count;
        foreach (var val in data.EnvelopesPerTrackMapping)
        {
            Write(val.Track);
            Write(val.LevelOfDetail);
            Write(val.Envelope);
        }

        info.NumGlobalLimits = (CUInt16)data.GlobalLimits.Count;
        foreach (var val in data.GlobalLimits)
        {
            Write(val.Max);
            Write(val.Mid);
            Write(val.Min);
            Write(val.Track);
            Write(val.Envelope);
            _writer.Write((byte)(val.IsCachable ? 1 : 0));
        }

        info.NumInfluencedPoses = (CUInt16)data.InfluencedPoses.Count;
        foreach (var val in data.InfluencedPoses)
        {
            Write(val.Track);
            Write(val.NumInfluences);
            Write(val.Type);
        }

        info.NumInfluenceIndices = (CUInt16)data.InfluenceIndices.Count;
        foreach (var val in data.InfluenceIndices)
        {
            Write(val);
        }

        info.NumUpperLowerFace = (CUInt16)data.UpperLowerFace.Count;
        foreach (var val in data.UpperLowerFace)
        {
            Write(val.Track);
            Write(val.Part);
            Write(val.Unknown);
        }

        info.NumLipsyncPosesSides = (CUInt16)data.LipsyncPosesSides.Count;
        foreach (var val in data.LipsyncPosesSides)
        {
            Write(val.Track);
            Write(val.Side);
            Write(val.Unknown);
        }

        info.NumGlobalCorrectiveEntries = (CUInt16)data.GlobalCorrectiveEntries.Count;
        foreach (var val in data.GlobalCorrectiveEntries)
        {
            Write(val.Index);
            _writer.Write((ushort)(((val.Track & 0xFFF) << 4) | (val.Unknown & 0xF)));
        }

        info.NumInbetweenCorrectiveEntries = (CUInt16)data.InbetweenCorrectiveEntries.Count;
        foreach (var val in data.InbetweenCorrectiveEntries)
        {
            Write(val.Index);
            _writer.Write((ushort)(((val.Track & 0xFFF) << 4) | (val.Unknown & 0xF)));
        }

        info.NumCorrectiveInfluencedPoses = (CUInt16)data.CorrectiveInfluencedPoses.Count;
        foreach (var val in data.CorrectiveInfluencedPoses)
        {
            Write(val.Index);
            Write(val.NumInfluences);
            Write(val.Type);
        }

        info.NumCorrectiveInfluenceIndices = (CUInt16)data.CorrectiveInfluenceIndices.Count;
        foreach (var val in data.CorrectiveInfluenceIndices)
        {
            Write(val);
        }

        info.NumAllMainPoses = (CUInt16)data.AllMainPoses.Count;
        foreach (var val in data.AllMainPoses)
        {
            Write(val.Track);
            Write(val.NumInbetweens);
            Write(val.Unknown);
        }

        info.NumAllMainPosesInbetweens = (CUInt16)data.AllMainPosesInbetweens.Count;
        foreach (var val in data.AllMainPosesInbetweens)
        {
            Write(val);
        }

        info.NumAllMainPosesInbetweenScopeMultipliers = (CUInt16)data.AllMainPosesInbetweenScopeMultipliers.Count;
        foreach (var val in data.AllMainPosesInbetweenScopeMultipliers)
        {
            Write(val);
        }

        info.NumWrinkles = (CUInt16)data.Wrinkles.Count;
        foreach (var val in data.Wrinkles)
        {
            Write(val);
        }
    }
}