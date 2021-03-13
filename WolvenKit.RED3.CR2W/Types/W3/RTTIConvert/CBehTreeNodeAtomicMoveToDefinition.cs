using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicMoveToDefinition : CBehTreeNodeAtomicActionDefinition
	{
		[Ordinal(1)] [RED("steeringGraph")] 		public CBehTreeValSteeringGraph SteeringGraph { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CBehTreeValFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("moveSpeed")] 		public CBehTreeValFloat MoveSpeed { get; set;}

		[Ordinal(4)] [RED("pathfindingTolerance")] 		public CBehTreeValFloat PathfindingTolerance { get; set;}

		[Ordinal(5)] [RED("moveType")] 		public CBehTreeValEMoveType MoveType { get; set;}

		[Ordinal(6)] [RED("angularTolerance")] 		public CFloat AngularTolerance { get; set;}

		[Ordinal(7)] [RED("keepPreviousMoveData")] 		public CBehTreeValBool KeepPreviousMoveData { get; set;}

		[Ordinal(8)] [RED("rotateAfterwards")] 		public CBehTreeValBool RotateAfterwards { get; set;}

		[Ordinal(9)] [RED("preciseArrival")] 		public CBehTreeValBool PreciseArrival { get; set;}

		public CBehTreeNodeAtomicMoveToDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeAtomicMoveToDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}