using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeLookAt : CBehaviorGraphConstraintNode
	{
		[RED("bone")] 		public CString Bone { get; set;}

		[RED("parentBone")] 		public CString ParentBone { get; set;}

		[RED("forwardDir")] 		public CEnum<EAxis> ForwardDir { get; set;}

		[RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[RED("horizontalLimitAngle")] 		public CFloat HorizontalLimitAngle { get; set;}

		[RED("upLimitAngle")] 		public CFloat UpLimitAngle { get; set;}

		[RED("downLimitAngle")] 		public CFloat DownLimitAngle { get; set;}

		[RED("rangeLimitUpAxis")] 		public CEnum<EAxis> RangeLimitUpAxis { get; set;}

		[RED("solverType")] 		public CEnum<ELookAtSolverType> SolverType { get; set;}

		[RED("deadZone")] 		public CFloat DeadZone { get; set;}

		[RED("deadZoneDist")] 		public CFloat DeadZoneDist { get; set;}

		public CBehaviorGraphConstraintNodeLookAt(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphConstraintNodeLookAt(cr2w);

	}
}