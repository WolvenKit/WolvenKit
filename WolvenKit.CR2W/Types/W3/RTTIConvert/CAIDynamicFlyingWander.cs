using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIDynamicFlyingWander : CAISubTree
	{
		[Ordinal(0)] [RED("chanceToTakeOff")] 		public CFloat ChanceToTakeOff { get; set;}

		[Ordinal(0)] [RED("chanceToLand")] 		public CFloat ChanceToLand { get; set;}

		[Ordinal(0)] [RED("landingGroundOffset")] 		public CFloat LandingGroundOffset { get; set;}

		[Ordinal(0)] [RED("onSpotLanding")] 		public CBool OnSpotLanding { get; set;}

		[Ordinal(0)] [RED("minFlyDistance")] 		public CFloat MinFlyDistance { get; set;}

		[Ordinal(0)] [RED("maxFlyDistance")] 		public CFloat MaxFlyDistance { get; set;}

		[Ordinal(0)] [RED("minHeight")] 		public CFloat MinHeight { get; set;}

		[Ordinal(0)] [RED("maxHeight")] 		public CFloat MaxHeight { get; set;}

		[Ordinal(0)] [RED("proximityToAllowTakeOff")] 		public CFloat ProximityToAllowTakeOff { get; set;}

		[Ordinal(0)] [RED("proximityToForceTakeOff")] 		public CFloat ProximityToForceTakeOff { get; set;}

		[Ordinal(0)] [RED("distanceFromPlayerToLand")] 		public CFloat DistanceFromPlayerToLand { get; set;}

		public CAIDynamicFlyingWander(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIDynamicFlyingWander(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}