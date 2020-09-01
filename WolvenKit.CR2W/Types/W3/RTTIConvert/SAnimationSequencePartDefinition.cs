using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationSequencePartDefinition : CVariable
	{
		[Ordinal(0)] [RED("animation")] 		public CName Animation { get; set;}

		[Ordinal(0)] [RED("syncType")] 		public CEnum<EAnimationManualSyncType> SyncType { get; set;}

		[Ordinal(0)] [RED("syncEventName")] 		public CName SyncEventName { get; set;}

		[Ordinal(0)] [RED("shouldSlide")] 		public CBool ShouldSlide { get; set;}

		[Ordinal(0)] [RED("shouldRotate")] 		public CBool ShouldRotate { get; set;}

		[Ordinal(0)] [RED("useRefBone")] 		public CName UseRefBone { get; set;}

		[Ordinal(0)] [RED("rotationTypeUsingRefBone")] 		public CEnum<ESyncRotationUsingRefBoneType> RotationTypeUsingRefBone { get; set;}

		[Ordinal(0)] [RED("finalPosition")] 		public Vector FinalPosition { get; set;}

		[Ordinal(0)] [RED("finalHeading")] 		public CFloat FinalHeading { get; set;}

		[Ordinal(0)] [RED("blendTransitionTime")] 		public CFloat BlendTransitionTime { get; set;}

		[Ordinal(0)] [RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[Ordinal(0)] [RED("blendOutTime")] 		public CFloat BlendOutTime { get; set;}

		[Ordinal(0)] [RED("allowBreakAtStart")] 		public CFloat AllowBreakAtStart { get; set;}

		[Ordinal(0)] [RED("allowBreakAtStartBeforeEventsEnd")] 		public CName AllowBreakAtStartBeforeEventsEnd { get; set;}

		[Ordinal(0)] [RED("allowBreakBeforeEnd")] 		public CFloat AllowBreakBeforeEnd { get; set;}

		[Ordinal(0)] [RED("allowBreakBeforeAtAfterEventsStart")] 		public CName AllowBreakBeforeAtAfterEventsStart { get; set;}

		[Ordinal(0)] [RED("sequenceIndex")] 		public CInt32 SequenceIndex { get; set;}

		[Ordinal(0)] [RED("disableProxyCollisions")] 		public CBool DisableProxyCollisions { get; set;}

		public SAnimationSequencePartDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationSequencePartDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}