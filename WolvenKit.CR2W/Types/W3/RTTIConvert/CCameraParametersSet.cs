using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraParametersSet : CObject
	{
		[RED("pivotPositionControllerName")] 		public CName PivotPositionControllerName { get; set;}

		[RED("pivotPositionControllerBlend")] 		public CFloat PivotPositionControllerBlend { get; set;}

		[RED("pivotPosForcedBlendOnNext")] 		public CFloat PivotPosForcedBlendOnNext { get; set;}

		[RED("pivotPositionBlendFromPos")] 		public CBool PivotPositionBlendFromPos { get; set;}

		[RED("forceBlendFromPosOnNextCam")] 		public CBool ForceBlendFromPosOnNextCam { get; set;}

		[RED("pivotRotationController")] 		public CName PivotRotationController { get; set;}

		[RED("pivotDistanceController")] 		public CName PivotDistanceController { get; set;}

		[RED("launchAnimation")] 		public CBool LaunchAnimation { get; set;}

		[RED("animationData")] 		public SCameraAnimationData AnimationData { get; set;}

		[RED("collisionOffset")] 		public Vector CollisionOffset { get; set;}

		public CCameraParametersSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraParametersSet(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}