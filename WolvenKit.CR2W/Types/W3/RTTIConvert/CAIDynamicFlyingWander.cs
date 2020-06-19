using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIDynamicFlyingWander : CAISubTree
	{
		[RED("chanceToTakeOff")] 		public CFloat ChanceToTakeOff { get; set;}

		[RED("chanceToLand")] 		public CFloat ChanceToLand { get; set;}

		[RED("landingGroundOffset")] 		public CFloat LandingGroundOffset { get; set;}

		[RED("onSpotLanding")] 		public CBool OnSpotLanding { get; set;}

		[RED("minFlyDistance")] 		public CFloat MinFlyDistance { get; set;}

		[RED("maxFlyDistance")] 		public CFloat MaxFlyDistance { get; set;}

		[RED("minHeight")] 		public CFloat MinHeight { get; set;}

		[RED("maxHeight")] 		public CFloat MaxHeight { get; set;}

		[RED("proximityToAllowTakeOff")] 		public CFloat ProximityToAllowTakeOff { get; set;}

		[RED("proximityToForceTakeOff")] 		public CFloat ProximityToForceTakeOff { get; set;}

		[RED("distanceFromPlayerToLand")] 		public CFloat DistanceFromPlayerToLand { get; set;}

		public CAIDynamicFlyingWander(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIDynamicFlyingWander(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}