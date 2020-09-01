using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraParametersSet : CObject
	{
		[Ordinal(1)] [RED("("pivotPositionControllerName")] 		public CName PivotPositionControllerName { get; set;}

		[Ordinal(2)] [RED("("pivotPositionControllerBlend")] 		public CFloat PivotPositionControllerBlend { get; set;}

		[Ordinal(3)] [RED("("pivotPosForcedBlendOnNext")] 		public CFloat PivotPosForcedBlendOnNext { get; set;}

		[Ordinal(4)] [RED("("pivotPositionBlendFromPos")] 		public CBool PivotPositionBlendFromPos { get; set;}

		[Ordinal(5)] [RED("("forceBlendFromPosOnNextCam")] 		public CBool ForceBlendFromPosOnNextCam { get; set;}

		[Ordinal(6)] [RED("("pivotRotationController")] 		public CName PivotRotationController { get; set;}

		[Ordinal(7)] [RED("("pivotDistanceController")] 		public CName PivotDistanceController { get; set;}

		[Ordinal(8)] [RED("("launchAnimation")] 		public CBool LaunchAnimation { get; set;}

		[Ordinal(9)] [RED("("animationData")] 		public SCameraAnimationData AnimationData { get; set;}

		[Ordinal(10)] [RED("("collisionOffset")] 		public Vector CollisionOffset { get; set;}

		public CCameraParametersSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraParametersSet(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}