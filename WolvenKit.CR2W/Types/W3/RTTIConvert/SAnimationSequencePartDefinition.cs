using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationSequencePartDefinition : CVariable
	{
		[RED("animation")] 		public CName Animation { get; set;}

		[RED("syncType")] 		public EAnimationManualSyncType SyncType { get; set;}

		[RED("syncEventName")] 		public CName SyncEventName { get; set;}

		[RED("shouldSlide")] 		public CBool ShouldSlide { get; set;}

		[RED("shouldRotate")] 		public CBool ShouldRotate { get; set;}

		[RED("useRefBone")] 		public CName UseRefBone { get; set;}

		[RED("rotationTypeUsingRefBone")] 		public ESyncRotationUsingRefBoneType RotationTypeUsingRefBone { get; set;}

		[RED("finalPosition")] 		public Vector FinalPosition { get; set;}

		[RED("finalHeading")] 		public CFloat FinalHeading { get; set;}

		[RED("blendTransitionTime")] 		public CFloat BlendTransitionTime { get; set;}

		[RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[RED("blendOutTime")] 		public CFloat BlendOutTime { get; set;}

		[RED("allowBreakAtStart")] 		public CFloat AllowBreakAtStart { get; set;}

		[RED("allowBreakAtStartBeforeEventsEnd")] 		public CName AllowBreakAtStartBeforeEventsEnd { get; set;}

		[RED("allowBreakBeforeEnd")] 		public CFloat AllowBreakBeforeEnd { get; set;}

		[RED("allowBreakBeforeAtAfterEventsStart")] 		public CName AllowBreakBeforeAtAfterEventsStart { get; set;}

		[RED("sequenceIndex")] 		public CInt32 SequenceIndex { get; set;}

		[RED("disableProxyCollisions")] 		public CBool DisableProxyCollisions { get; set;}

		public SAnimationSequencePartDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAnimationSequencePartDefinition(cr2w);

	}
}