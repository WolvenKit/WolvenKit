using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSwim : CExplorationStateAbstract
	{
		[RED("solveCollisionsForward")] 		public CBool SolveCollisionsForward { get; set;}

		[RED("smoothPenetration")] 		public CBool SmoothPenetration { get; set;}

		[RED("collisionUpOffset")] 		public CFloat CollisionUpOffset { get; set;}

		[RED("collisionDistance")] 		public CFloat CollisionDistance { get; set;}

		[RED("collisionRadius")] 		public CFloat CollisionRadius { get; set;}

		[RED("collisionPenetrationMax")] 		public CFloat CollisionPenetrationMax { get; set;}

		[RED("collisionPenetration")] 		public Vector CollisionPenetration { get; set;}

		[RED("smoothSpeed")] 		public CFloat SmoothSpeed { get; set;}

		public CExplorationStateSwim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSwim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}