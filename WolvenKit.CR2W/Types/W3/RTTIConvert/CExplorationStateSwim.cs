using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSwim : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("("solveCollisionsForward")] 		public CBool SolveCollisionsForward { get; set;}

		[Ordinal(2)] [RED("("smoothPenetration")] 		public CBool SmoothPenetration { get; set;}

		[Ordinal(3)] [RED("("collisionUpOffset")] 		public CFloat CollisionUpOffset { get; set;}

		[Ordinal(4)] [RED("("collisionDistance")] 		public CFloat CollisionDistance { get; set;}

		[Ordinal(5)] [RED("("collisionRadius")] 		public CFloat CollisionRadius { get; set;}

		[Ordinal(6)] [RED("("collisionPenetrationMax")] 		public CFloat CollisionPenetrationMax { get; set;}

		[Ordinal(7)] [RED("("collisionPenetration")] 		public Vector CollisionPenetration { get; set;}

		[Ordinal(8)] [RED("("smoothSpeed")] 		public CFloat SmoothSpeed { get; set;}

		[Ordinal(9)] [RED("("zeroVec")] 		public Vector ZeroVec { get; set;}

		public CExplorationStateSwim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSwim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}