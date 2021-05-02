using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPredictionInfo : CVariable
	{
		[Ordinal(1)] [RED("distanceToCollision")] 		public CFloat DistanceToCollision { get; set;}

		[Ordinal(2)] [RED("normalYaw")] 		public CFloat NormalYaw { get; set;}

		[Ordinal(3)] [RED("turnAngle")] 		public CFloat TurnAngle { get; set;}

		[Ordinal(4)] [RED("leftGroundLevel")] 		public CFloat LeftGroundLevel { get; set;}

		[Ordinal(5)] [RED("frontGroundLevel")] 		public CFloat FrontGroundLevel { get; set;}

		[Ordinal(6)] [RED("rightGroundLevel")] 		public CFloat RightGroundLevel { get; set;}

		public SPredictionInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}