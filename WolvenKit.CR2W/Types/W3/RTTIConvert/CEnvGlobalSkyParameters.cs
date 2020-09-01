using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGlobalSkyParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("activatedActivateFactor")] 		public CBool ActivatedActivateFactor { get; set;}

		[Ordinal(3)] [RED("activateFactor")] 		public CFloat ActivateFactor { get; set;}

		[Ordinal(4)] [RED("skyColor")] 		public SSimpleCurve SkyColor { get; set;}

		[Ordinal(5)] [RED("skyColorHorizon")] 		public SSimpleCurve SkyColorHorizon { get; set;}

		[Ordinal(6)] [RED("horizonVerticalAttenuation")] 		public SSimpleCurve HorizonVerticalAttenuation { get; set;}

		[Ordinal(7)] [RED("sunColorSky")] 		public SSimpleCurve SunColorSky { get; set;}

		[Ordinal(8)] [RED("sunColorSkyBrightness")] 		public SSimpleCurve SunColorSkyBrightness { get; set;}

		[Ordinal(9)] [RED("sunAreaSkySize")] 		public SSimpleCurve SunAreaSkySize { get; set;}

		[Ordinal(10)] [RED("sunColorHorizon")] 		public SSimpleCurve SunColorHorizon { get; set;}

		[Ordinal(11)] [RED("sunColorHorizonHorizontalScale")] 		public SSimpleCurve SunColorHorizonHorizontalScale { get; set;}

		[Ordinal(12)] [RED("sunBackHorizonColor")] 		public SSimpleCurve SunBackHorizonColor { get; set;}

		[Ordinal(13)] [RED("sunInfluence")] 		public SSimpleCurve SunInfluence { get; set;}

		[Ordinal(14)] [RED("moonColorSky")] 		public SSimpleCurve MoonColorSky { get; set;}

		[Ordinal(15)] [RED("moonColorSkyBrightness")] 		public SSimpleCurve MoonColorSkyBrightness { get; set;}

		[Ordinal(16)] [RED("moonAreaSkySize")] 		public SSimpleCurve MoonAreaSkySize { get; set;}

		[Ordinal(17)] [RED("moonColorHorizon")] 		public SSimpleCurve MoonColorHorizon { get; set;}

		[Ordinal(18)] [RED("moonColorHorizonHorizontalScale")] 		public SSimpleCurve MoonColorHorizonHorizontalScale { get; set;}

		[Ordinal(19)] [RED("moonBackHorizonColor")] 		public SSimpleCurve MoonBackHorizonColor { get; set;}

		[Ordinal(20)] [RED("moonInfluence")] 		public SSimpleCurve MoonInfluence { get; set;}

		[Ordinal(21)] [RED("globalSkyBrightness")] 		public SSimpleCurve GlobalSkyBrightness { get; set;}

		public CEnvGlobalSkyParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalSkyParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}