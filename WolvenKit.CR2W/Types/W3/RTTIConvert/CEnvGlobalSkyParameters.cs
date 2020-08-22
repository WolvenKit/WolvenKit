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
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("activatedActivateFactor")] 		public CBool ActivatedActivateFactor { get; set;}

		[RED("activateFactor")] 		public CFloat ActivateFactor { get; set;}

		[RED("skyColor")] 		public SSimpleCurve SkyColor { get; set;}

		[RED("skyColorHorizon")] 		public SSimpleCurve SkyColorHorizon { get; set;}

		[RED("horizonVerticalAttenuation")] 		public SSimpleCurve HorizonVerticalAttenuation { get; set;}

		[RED("sunColorSky")] 		public SSimpleCurve SunColorSky { get; set;}

		[RED("sunColorSkyBrightness")] 		public SSimpleCurve SunColorSkyBrightness { get; set;}

		[RED("sunAreaSkySize")] 		public SSimpleCurve SunAreaSkySize { get; set;}

		[RED("sunColorHorizon")] 		public SSimpleCurve SunColorHorizon { get; set;}

		[RED("sunColorHorizonHorizontalScale")] 		public SSimpleCurve SunColorHorizonHorizontalScale { get; set;}

		[RED("sunBackHorizonColor")] 		public SSimpleCurve SunBackHorizonColor { get; set;}

		[RED("sunInfluence")] 		public SSimpleCurve SunInfluence { get; set;}

		[RED("moonColorSky")] 		public SSimpleCurve MoonColorSky { get; set;}

		[RED("moonColorSkyBrightness")] 		public SSimpleCurve MoonColorSkyBrightness { get; set;}

		[RED("moonAreaSkySize")] 		public SSimpleCurve MoonAreaSkySize { get; set;}

		[RED("moonColorHorizon")] 		public SSimpleCurve MoonColorHorizon { get; set;}

		[RED("moonColorHorizonHorizontalScale")] 		public SSimpleCurve MoonColorHorizonHorizontalScale { get; set;}

		[RED("moonBackHorizonColor")] 		public SSimpleCurve MoonBackHorizonColor { get; set;}

		[RED("moonInfluence")] 		public SSimpleCurve MoonInfluence { get; set;}

		[RED("globalSkyBrightness")] 		public SSimpleCurve GlobalSkyBrightness { get; set;}

		public CEnvGlobalSkyParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalSkyParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}