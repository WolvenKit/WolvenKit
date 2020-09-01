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
		[Ordinal(0)] [RED("("solveCollisionsForward")] 		public CBool SolveCollisionsForward { get; set;}

		[Ordinal(0)] [RED("("smoothPenetration")] 		public CBool SmoothPenetration { get; set;}

		[Ordinal(0)] [RED("("collisionUpOffset")] 		public CFloat CollisionUpOffset { get; set;}

		[Ordinal(0)] [RED("("collisionDistance")] 		public CFloat CollisionDistance { get; set;}

		[Ordinal(0)] [RED("("collisionRadius")] 		public CFloat CollisionRadius { get; set;}

		[Ordinal(0)] [RED("("collisionPenetrationMax")] 		public CFloat CollisionPenetrationMax { get; set;}

		[Ordinal(0)] [RED("("collisionPenetration")] 		public Vector CollisionPenetration { get; set;}

		[Ordinal(0)] [RED("("smoothSpeed")] 		public CFloat SmoothSpeed { get; set;}

		[Ordinal(0)] [RED("("zeroVec")] 		public Vector ZeroVec { get; set;}

		public CExplorationStateSwim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSwim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}