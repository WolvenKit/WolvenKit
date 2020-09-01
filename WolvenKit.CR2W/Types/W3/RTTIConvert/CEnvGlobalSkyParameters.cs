using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGlobalSkyParameters : CVariable
	{
		[Ordinal(0)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("activatedActivateFactor")] 		public CBool ActivatedActivateFactor { get; set;}

		[Ordinal(0)] [RED("activateFactor")] 		public CFloat ActivateFactor { get; set;}

		[Ordinal(0)] [RED("skyColor")] 		public SSimpleCurve SkyColor { get; set;}

		[Ordinal(0)] [RED("skyColorHorizon")] 		public SSimpleCurve SkyColorHorizon { get; set;}

		[Ordinal(0)] [RED("horizonVerticalAttenuation")] 		public SSimpleCurve HorizonVerticalAttenuation { get; set;}

		[Ordinal(0)] [RED("sunColorSky")] 		public SSimpleCurve SunColorSky { get; set;}

		[Ordinal(0)] [RED("sunColorSkyBrightness")] 		public SSimpleCurve SunColorSkyBrightness { get; set;}

		[Ordinal(0)] [RED("sunAreaSkySize")] 		public SSimpleCurve SunAreaSkySize { get; set;}

		[Ordinal(0)] [RED("sunColorHorizon")] 		public SSimpleCurve SunColorHorizon { get; set;}

		[Ordinal(0)] [RED("sunColorHorizonHorizontalScale")] 		public SSimpleCurve SunColorHorizonHorizontalScale { get; set;}

		[Ordinal(0)] [RED("sunBackHorizonColor")] 		public SSimpleCurve SunBackHorizonColor { get; set;}

		[Ordinal(0)] [RED("sunInfluence")] 		public SSimpleCurve SunInfluence { get; set;}

		[Ordinal(0)] [RED("moonColorSky")] 		public SSimpleCurve MoonColorSky { get; set;}

		[Ordinal(0)] [RED("moonColorSkyBrightness")] 		public SSimpleCurve MoonColorSkyBrightness { get; set;}

		[Ordinal(0)] [RED("moonAreaSkySize")] 		public SSimpleCurve MoonAreaSkySize { get; set;}

		[Ordinal(0)] [RED("moonColorHorizon")] 		public SSimpleCurve MoonColorHorizon { get; set;}

		[Ordinal(0)] [RED("moonColorHorizonHorizontalScale")] 		public SSimpleCurve MoonColorHorizonHorizontalScale { get; set;}

		[Ordinal(0)] [RED("moonBackHorizonColor")] 		public SSimpleCurve MoonBackHorizonColor { get; set;}

		[Ordinal(0)] [RED("moonInfluence")] 		public SSimpleCurve MoonInfluence { get; set;}

		[Ordinal(0)] [RED("globalSkyBrightness")] 		public SSimpleCurve GlobalSkyBrightness { get; set;}

		public CEnvGlobalSkyParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalSkyParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}