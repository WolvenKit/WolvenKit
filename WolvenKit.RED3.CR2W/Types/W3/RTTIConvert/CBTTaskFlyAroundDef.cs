using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAroundDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[Ordinal(2)] [RED("altitude")] 		public CBehTreeValFloat Altitude { get; set;}

		[Ordinal(3)] [RED("tolerance")] 		public CBehTreeValFloat Tolerance { get; set;}

		[Ordinal(4)] [RED("frontalHeadingOffset")] 		public CBehTreeValInt FrontalHeadingOffset { get; set;}

		[Ordinal(5)] [RED("landingGroundOffset")] 		public CBehTreeValFloat LandingGroundOffset { get; set;}

		[Ordinal(6)] [RED("randomHeight")] 		public CBehTreeValInt RandomHeight { get; set;}

		[Ordinal(7)] [RED("flightMaxDuration")] 		public CBehTreeValFloat FlightMaxDuration { get; set;}

		[Ordinal(8)] [RED("anchorPoint")] 		public CHandle<CEncounter> AnchorPoint { get; set;}

		[Ordinal(9)] [RED("anchorPointAC")] 		public CHandle<CComponent> AnchorPointAC { get; set;}

		public CBTTaskFlyAroundDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyAroundDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}