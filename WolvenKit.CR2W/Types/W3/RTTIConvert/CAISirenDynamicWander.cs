using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAISirenDynamicWander : CAISubTree
	{
		[RED("chanceToTakeOff")] 		public CFloat ChanceToTakeOff { get; set;}

		[RED("chanceToLand")] 		public CFloat ChanceToLand { get; set;}

		[RED("chanceToDive")] 		public CFloat ChanceToDive { get; set;}

		[RED("minFlyDistance")] 		public CFloat MinFlyDistance { get; set;}

		[RED("maxFlyDistance")] 		public CFloat MaxFlyDistance { get; set;}

		[RED("minHeight")] 		public CFloat MinHeight { get; set;}

		[RED("maxHeight")] 		public CFloat MaxHeight { get; set;}

		[RED("proximityToAllowTakeOff")] 		public CFloat ProximityToAllowTakeOff { get; set;}

		[RED("proximityToForceTakeOff")] 		public CFloat ProximityToForceTakeOff { get; set;}

		[RED("distanceFromPlayerToLand")] 		public CFloat DistanceFromPlayerToLand { get; set;}

		public CAISirenDynamicWander(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAISirenDynamicWander(cr2w);

	}
}