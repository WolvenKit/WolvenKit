using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGlobalLightingTrajectory : CVariable
	{
		[Ordinal(0)] [RED("("yawDegrees")] 		public CFloat YawDegrees { get; set;}

		[Ordinal(0)] [RED("("yawDegreesSunOffset")] 		public CFloat YawDegreesSunOffset { get; set;}

		[Ordinal(0)] [RED("("yawDegreesMoonOffset")] 		public CFloat YawDegreesMoonOffset { get; set;}

		[Ordinal(0)] [RED("("sunCurveShiftFactor")] 		public CFloat SunCurveShiftFactor { get; set;}

		[Ordinal(0)] [RED("("moonCurveShiftFactor")] 		public CFloat MoonCurveShiftFactor { get; set;}

		[Ordinal(0)] [RED("("sunSqueeze")] 		public CFloat SunSqueeze { get; set;}

		[Ordinal(0)] [RED("("moonSqueeze")] 		public CFloat MoonSqueeze { get; set;}

		[Ordinal(0)] [RED("("sunHeight")] 		public SSimpleCurve SunHeight { get; set;}

		[Ordinal(0)] [RED("("moonHeight")] 		public SSimpleCurve MoonHeight { get; set;}

		[Ordinal(0)] [RED("("lightHeight")] 		public SSimpleCurve LightHeight { get; set;}

		[Ordinal(0)] [RED("("lightDirChoice")] 		public SSimpleCurve LightDirChoice { get; set;}

		[Ordinal(0)] [RED("("skyDayAmount")] 		public SSimpleCurve SkyDayAmount { get; set;}

		[Ordinal(0)] [RED("("moonShaftsBeginHour")] 		public CFloat MoonShaftsBeginHour { get; set;}

		[Ordinal(0)] [RED("("moonShaftsEndHour")] 		public CFloat MoonShaftsEndHour { get; set;}

		public CGlobalLightingTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGlobalLightingTrajectory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}