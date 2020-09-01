using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSkeleton : CResource
	{
		[Ordinal(1)] [RED("lodBoneNum_1")] 		public CInt32 LodBoneNum_1 { get; set;}

		[Ordinal(2)] [RED("walkSpeed")] 		public CFloat WalkSpeed { get; set;}

		[Ordinal(3)] [RED("slowRunSpeed")] 		public CFloat SlowRunSpeed { get; set;}

		[Ordinal(4)] [RED("fastRunSpeed")] 		public CFloat FastRunSpeed { get; set;}

		[Ordinal(5)] [RED("sprintSpeed")] 		public CFloat SprintSpeed { get; set;}

		[Ordinal(6)] [RED("walkSpeedRel")] 		public CFloat WalkSpeedRel { get; set;}

		[Ordinal(7)] [RED("slowRunSpeedRel")] 		public CFloat SlowRunSpeedRel { get; set;}

		[Ordinal(8)] [RED("fastRunSpeedRel")] 		public CFloat FastRunSpeedRel { get; set;}

		[Ordinal(9)] [RED("sprintSpeedRel")] 		public CFloat SprintSpeedRel { get; set;}

		[Ordinal(10)] [RED("poseCompression")] 		public CPtr<IPoseCompression> PoseCompression { get; set;}

		[Ordinal(11)] [RED("bboxGenerator")] 		public CPtr<CPoseBBoxGenerator> BboxGenerator { get; set;}

		[Ordinal(12)] [RED("controlRigDefinition")] 		public CPtr<TCrDefinition> ControlRigDefinition { get; set;}

		[Ordinal(13)] [RED("controlRigDefaultPropertySet")] 		public CPtr<TCrPropertySet> ControlRigDefaultPropertySet { get; set;}

		[Ordinal(14)] [RED("skeletonMappers", 2,0)] 		public CArray<CPtr<CSkeleton2SkeletonMapper>> SkeletonMappers { get; set;}

		[Ordinal(15)] [RED("controlRigSettings")] 		public CPtr<CControlRigSettings> ControlRigSettings { get; set;}

		[Ordinal(16)] [RED("teleportDetectorData")] 		public CPtr<CTeleportDetectorData> TeleportDetectorData { get; set;}

		[Ordinal(17)] [RED("lastNonStreamableBoneName")] 		public CName LastNonStreamableBoneName { get; set;}

		[Ordinal(18)] [RED("bones", 2,0)] 		public CArray<SSkeletonBone> Bones { get; set;}

		[Ordinal(19)] [RED("tracks", 2,0)] 		public CArray<SSkeletonTrack> Tracks { get; set;}

		[Ordinal(20)] [RED("parentIndices", 2,0)] 		public CArray<CInt16> ParentIndices { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeleton(cr2w, parent, name);

	}
}