using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class AnimFacialSetupMainPosesDataWriter : Red4Writer
{
    public AnimFacialSetupMainPosesDataWriter(Stream ms) : base(ms)
    {

    }

    public void WriteBuffer(AnimFacialSetupMainPosesDataBuffer buffer, animFacialSetup animFacialSetup)
    {
        WriteData(buffer.Face, animFacialSetup.PosesInfo.Face);
        WriteData(buffer.Tongue, animFacialSetup.PosesInfo.Tongue);
        WriteData(buffer.Eyes, animFacialSetup.PosesInfo.Eyes);
    }

    private void WriteData(AnimFacialSetupPosesPartData data, animFacialSetup_OneSermoPoseBufferInfo info)
    {
        info.NumMainPoses = (CUInt16)data.Poses.Count;
        foreach (var pose in data.Poses)
        {
            Write(pose.TransformIdx);
            Write(pose.ScaleIdx);

            var bitwise = pose.NumTransforms & 0x7FFF;
            if (pose.IsScale)
            {
                bitwise |= 0x8000;
            }
            _writer.Write((ushort)bitwise);

            Write(pose.Flag1);
            Write(pose.Flag2);
            Write(pose.Flag3);
        }

        info.NumMainTransforms = (uint)data.Transforms.Count;
        foreach (var transform in data.Transforms)
        {
            Write(transform.Rotation.I);
            Write(transform.Rotation.J);
            Write(transform.Rotation.K);
            Write(transform.Rotation.R);

            Write(transform.Translation.X);
            Write(transform.Translation.Y);
            Write(transform.Translation.Z);

            Write(transform.Bone);
            Write(transform.JointRegion);
            Write(transform.Unknown);
        }

        info.NumMainScales = (uint)data.Scales.Count;
        foreach (var scale in data.Scales)
        {
            Write(scale.I);
            Write(scale.J);
            Write(scale.K);
            Write(scale.R);
        }
    }
}