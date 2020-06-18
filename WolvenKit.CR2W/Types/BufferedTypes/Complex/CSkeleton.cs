using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CSkeleton : CResource
    {
        [RED("lodBoneNum_1")] public CInt32 LodBoneNum_1 { get; set; }

        [RED("walkSpeed")] public CFloat WalkSpeed { get; set; }

        [RED("slowRunSpeed")] public CFloat SlowRunSpeed { get; set; }

        [RED("fastRunSpeed")] public CFloat FastRunSpeed { get; set; }

        [RED("sprintSpeed")] public CFloat SprintSpeed { get; set; }

        [RED("walkSpeedRel")] public CFloat WalkSpeedRel { get; set; }

        [RED("slowRunSpeedRel")] public CFloat SlowRunSpeedRel { get; set; }

        [RED("fastRunSpeedRel")] public CFloat FastRunSpeedRel { get; set; }

        [RED("sprintSpeedRel")] public CFloat SprintSpeedRel { get; set; }

        [RED("poseCompression")] public CPtr<IPoseCompression> PoseCompression { get; set; }

        [RED("bboxGenerator")] public CPtr<CPoseBBoxGenerator> BboxGenerator { get; set; }

        [RED("controlRigDefinition")] public CPtr<TCrDefinition> ControlRigDefinition { get; set; }

        [RED("controlRigDefaultPropertySet")] public CPtr<TCrPropertySet> ControlRigDefaultPropertySet { get; set; }

        [RED("skeletonMappers", 2, 0)] public CArray<CPtr<CSkeleton2SkeletonMapper>> SkeletonMappers { get; set; }

        [RED("controlRigSettings")] public CPtr<CControlRigSettings> ControlRigSettings { get; set; }

        [RED("teleportDetectorData")] public CPtr<CTeleportDetectorData> TeleportDetectorData { get; set; }

        [RED("lastNonStreamableBoneName")] public CName LastNonStreamableBoneName { get; set; }

        [RED("bones", 2, 0)] public CArray<SSkeletonBone> Bones { get; set; }

        [RED("tracks", 2, 0)] public CArray<SSkeletonTrack> Tracks { get; set; }

        [RED("parentIndices", 2, 0)] public CArray<CInt16> ParentIndices { get; set; }

        [REDBuffer(true)] public CCompressedBuffer<SSkeletonRigData> rigdata { get; set; }

        public CSkeleton(CR2WFile cr2w) : base(cr2w)
        {
            rigdata = new CCompressedBuffer<SSkeletonRigData>(cr2w, _ => new SSkeletonRigData(_)) { Name = "rigdata" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // get bonecount for compressed buffers
            int bonecount = Bones.Count;

            rigdata.Read(file, (uint)bonecount * 48, bonecount);
            
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            rigdata.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSkeleton(cr2w);
        }

    }
}