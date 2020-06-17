using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPredictionInfo : CVariable
	{
		[RED("distanceToCollision")] 		public CFloat DistanceToCollision { get; set;}

		[RED("normalYaw")] 		public CFloat NormalYaw { get; set;}

		[RED("turnAngle")] 		public CFloat TurnAngle { get; set;}

		[RED("leftGroundLevel")] 		public CFloat LeftGroundLevel { get; set;}

		[RED("frontGroundLevel")] 		public CFloat FrontGroundLevel { get; set;}

		[RED("rightGroundLevel")] 		public CFloat RightGroundLevel { get; set;}

		public SPredictionInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SPredictionInfo(cr2w);

	}
}