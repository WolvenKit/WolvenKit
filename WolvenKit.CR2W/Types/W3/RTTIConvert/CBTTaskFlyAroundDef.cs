using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAroundDef : IBehTreeTaskDefinition
	{
		[RED("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[RED("altitude")] 		public CBehTreeValFloat Altitude { get; set;}

		[RED("tolerance")] 		public CBehTreeValFloat Tolerance { get; set;}

		[RED("frontalHeadingOffset")] 		public CBehTreeValInt FrontalHeadingOffset { get; set;}

		[RED("landingGroundOffset")] 		public CBehTreeValFloat LandingGroundOffset { get; set;}

		[RED("randomHeight")] 		public CBehTreeValInt RandomHeight { get; set;}

		[RED("flightMaxDuration")] 		public CBehTreeValFloat FlightMaxDuration { get; set;}

		public CBTTaskFlyAroundDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskFlyAroundDef(cr2w);

	}
}