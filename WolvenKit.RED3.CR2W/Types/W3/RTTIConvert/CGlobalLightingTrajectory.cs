using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGlobalLightingTrajectory : CVariable
	{
		[Ordinal(1)] [RED("yawDegrees")] 		public CFloat YawDegrees { get; set;}

		[Ordinal(2)] [RED("yawDegreesSunOffset")] 		public CFloat YawDegreesSunOffset { get; set;}

		[Ordinal(3)] [RED("yawDegreesMoonOffset")] 		public CFloat YawDegreesMoonOffset { get; set;}

		[Ordinal(4)] [RED("sunCurveShiftFactor")] 		public CFloat SunCurveShiftFactor { get; set;}

		[Ordinal(5)] [RED("moonCurveShiftFactor")] 		public CFloat MoonCurveShiftFactor { get; set;}

		[Ordinal(6)] [RED("sunSqueeze")] 		public CFloat SunSqueeze { get; set;}

		[Ordinal(7)] [RED("moonSqueeze")] 		public CFloat MoonSqueeze { get; set;}

		[Ordinal(8)] [RED("sunHeight")] 		public SSimpleCurve SunHeight { get; set;}

		[Ordinal(9)] [RED("moonHeight")] 		public SSimpleCurve MoonHeight { get; set;}

		[Ordinal(10)] [RED("lightHeight")] 		public SSimpleCurve LightHeight { get; set;}

		[Ordinal(11)] [RED("lightDirChoice")] 		public SSimpleCurve LightDirChoice { get; set;}

		[Ordinal(12)] [RED("skyDayAmount")] 		public SSimpleCurve SkyDayAmount { get; set;}

		[Ordinal(13)] [RED("moonShaftsBeginHour")] 		public CFloat MoonShaftsBeginHour { get; set;}

		[Ordinal(14)] [RED("moonShaftsEndHour")] 		public CFloat MoonShaftsEndHour { get; set;}

		public CGlobalLightingTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGlobalLightingTrajectory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}