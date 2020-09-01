using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeLookAt : CBehaviorGraphConstraintNode
	{
		[Ordinal(1)] [RED("("bone")] 		public CString Bone { get; set;}

		[Ordinal(2)] [RED("("parentBone")] 		public CString ParentBone { get; set;}

		[Ordinal(3)] [RED("("forwardDir")] 		public CEnum<EAxis> ForwardDir { get; set;}

		[Ordinal(4)] [RED("("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(5)] [RED("("horizontalLimitAngle")] 		public CFloat HorizontalLimitAngle { get; set;}

		[Ordinal(6)] [RED("("upLimitAngle")] 		public CFloat UpLimitAngle { get; set;}

		[Ordinal(7)] [RED("("downLimitAngle")] 		public CFloat DownLimitAngle { get; set;}

		[Ordinal(8)] [RED("("rangeLimitUpAxis")] 		public CEnum<EAxis> RangeLimitUpAxis { get; set;}

		[Ordinal(9)] [RED("("solverType")] 		public CEnum<ELookAtSolverType> SolverType { get; set;}

		[Ordinal(10)] [RED("("deadZone")] 		public CFloat DeadZone { get; set;}

		[Ordinal(11)] [RED("("deadZoneDist")] 		public CFloat DeadZoneDist { get; set;}

		public CBehaviorGraphConstraintNodeLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNodeLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}