using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGlobalLightingTrajectory : CVariable
	{
		[RED("yawDegrees")] 		public CFloat YawDegrees { get; set;}

		[RED("yawDegreesSunOffset")] 		public CFloat YawDegreesSunOffset { get; set;}

		[RED("yawDegreesMoonOffset")] 		public CFloat YawDegreesMoonOffset { get; set;}

		[RED("sunCurveShiftFactor")] 		public CFloat SunCurveShiftFactor { get; set;}

		[RED("moonCurveShiftFactor")] 		public CFloat MoonCurveShiftFactor { get; set;}

		[RED("sunSqueeze")] 		public CFloat SunSqueeze { get; set;}

		[RED("moonSqueeze")] 		public CFloat MoonSqueeze { get; set;}

		[RED("sunHeight")] 		public SSimpleCurve SunHeight { get; set;}

		[RED("moonHeight")] 		public SSimpleCurve MoonHeight { get; set;}

		[RED("lightHeight")] 		public SSimpleCurve LightHeight { get; set;}

		[RED("lightDirChoice")] 		public SSimpleCurve LightDirChoice { get; set;}

		[RED("skyDayAmount")] 		public SSimpleCurve SkyDayAmount { get; set;}

		[RED("moonShaftsBeginHour")] 		public CFloat MoonShaftsBeginHour { get; set;}

		[RED("moonShaftsEndHour")] 		public CFloat MoonShaftsEndHour { get; set;}

		public CGlobalLightingTrajectory(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CGlobalLightingTrajectory(cr2w);

	}
}