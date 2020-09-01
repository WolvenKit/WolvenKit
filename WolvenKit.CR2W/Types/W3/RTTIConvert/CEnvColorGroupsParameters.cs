using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvColorGroupsParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("defaultGroup")] 		public SSimpleCurve DefaultGroup { get; set;}

		[Ordinal(0)] [RED("("lightsDefault")] 		public SSimpleCurve LightsDefault { get; set;}

		[Ordinal(0)] [RED("("lightsDawn")] 		public SSimpleCurve LightsDawn { get; set;}

		[Ordinal(0)] [RED("("lightsNoon")] 		public SSimpleCurve LightsNoon { get; set;}

		[Ordinal(0)] [RED("("lightsEvening")] 		public SSimpleCurve LightsEvening { get; set;}

		[Ordinal(0)] [RED("("lightsNight")] 		public SSimpleCurve LightsNight { get; set;}

		[Ordinal(0)] [RED("("fxDefault")] 		public SSimpleCurve FxDefault { get; set;}

		[Ordinal(0)] [RED("("fxFire")] 		public SSimpleCurve FxFire { get; set;}

		[Ordinal(0)] [RED("("fxFireFlares")] 		public SSimpleCurve FxFireFlares { get; set;}

		[Ordinal(0)] [RED("("fxFireLight")] 		public SSimpleCurve FxFireLight { get; set;}

		[Ordinal(0)] [RED("("fxSmoke")] 		public SSimpleCurve FxSmoke { get; set;}

		[Ordinal(0)] [RED("("fxSmokeExplosion")] 		public SSimpleCurve FxSmokeExplosion { get; set;}

		[Ordinal(0)] [RED("("fxSky")] 		public SSimpleCurve FxSky { get; set;}

		[Ordinal(0)] [RED("("fxSkyAlpha")] 		public SSimpleCurve FxSkyAlpha { get; set;}

		[Ordinal(0)] [RED("("fxSkyNight")] 		public SSimpleCurve FxSkyNight { get; set;}

		[Ordinal(0)] [RED("("fxSkyNightAlpha")] 		public SSimpleCurve FxSkyNightAlpha { get; set;}

		[Ordinal(0)] [RED("("fxSkyDawn")] 		public SSimpleCurve FxSkyDawn { get; set;}

		[Ordinal(0)] [RED("("fxSkyDawnAlpha")] 		public SSimpleCurve FxSkyDawnAlpha { get; set;}

		[Ordinal(0)] [RED("("fxSkyNoon")] 		public SSimpleCurve FxSkyNoon { get; set;}

		[Ordinal(0)] [RED("("fxSkyNoonAlpha")] 		public SSimpleCurve FxSkyNoonAlpha { get; set;}

		[Ordinal(0)] [RED("("fxSkySunset")] 		public SSimpleCurve FxSkySunset { get; set;}

		[Ordinal(0)] [RED("("fxSkySunsetAlpha")] 		public SSimpleCurve FxSkySunsetAlpha { get; set;}

		[Ordinal(0)] [RED("("fxSkyRain")] 		public SSimpleCurve FxSkyRain { get; set;}

		[Ordinal(0)] [RED("("fxSkyRainAlpha")] 		public SSimpleCurve FxSkyRainAlpha { get; set;}

		[Ordinal(0)] [RED("("mainCloudsMiddle")] 		public SSimpleCurve MainCloudsMiddle { get; set;}

		[Ordinal(0)] [RED("("mainCloudsMiddleAlpha")] 		public SSimpleCurve MainCloudsMiddleAlpha { get; set;}

		[Ordinal(0)] [RED("("mainCloudsFront")] 		public SSimpleCurve MainCloudsFront { get; set;}

		[Ordinal(0)] [RED("("mainCloudsFrontAlpha")] 		public SSimpleCurve MainCloudsFrontAlpha { get; set;}

		[Ordinal(0)] [RED("("mainCloudsBack")] 		public SSimpleCurve MainCloudsBack { get; set;}

		[Ordinal(0)] [RED("("mainCloudsBackAlpha")] 		public SSimpleCurve MainCloudsBackAlpha { get; set;}

		[Ordinal(0)] [RED("("mainCloudsRim")] 		public SSimpleCurve MainCloudsRim { get; set;}

		[Ordinal(0)] [RED("("mainCloudsRimAlpha")] 		public SSimpleCurve MainCloudsRimAlpha { get; set;}

		[Ordinal(0)] [RED("("backgroundCloudsFront")] 		public SSimpleCurve BackgroundCloudsFront { get; set;}

		[Ordinal(0)] [RED("("backgroundCloudsFrontAlpha")] 		public SSimpleCurve BackgroundCloudsFrontAlpha { get; set;}

		[Ordinal(0)] [RED("("backgroundCloudsBack")] 		public SSimpleCurve BackgroundCloudsBack { get; set;}

		[Ordinal(0)] [RED("("backgroundCloudsBackAlpha")] 		public SSimpleCurve BackgroundCloudsBackAlpha { get; set;}

		[Ordinal(0)] [RED("("backgroundHazeFront")] 		public SSimpleCurve BackgroundHazeFront { get; set;}

		[Ordinal(0)] [RED("("backgroundHazeFrontAlpha")] 		public SSimpleCurve BackgroundHazeFrontAlpha { get; set;}

		[Ordinal(0)] [RED("("backgroundHazeBack")] 		public SSimpleCurve BackgroundHazeBack { get; set;}

		[Ordinal(0)] [RED("("backgroundHazeBackAlpha")] 		public SSimpleCurve BackgroundHazeBackAlpha { get; set;}

		[Ordinal(0)] [RED("("fxBlood")] 		public SSimpleCurve FxBlood { get; set;}

		[Ordinal(0)] [RED("("fxWater")] 		public SSimpleCurve FxWater { get; set;}

		[Ordinal(0)] [RED("("fxFog")] 		public SSimpleCurve FxFog { get; set;}

		[Ordinal(0)] [RED("("fxTrails")] 		public SSimpleCurve FxTrails { get; set;}

		[Ordinal(0)] [RED("("fxScreenParticles")] 		public SSimpleCurve FxScreenParticles { get; set;}

		[Ordinal(0)] [RED("("fxLightShaft")] 		public SSimpleCurve FxLightShaft { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftSun")] 		public SSimpleCurve FxLightShaftSun { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftInteriorDawn")] 		public SSimpleCurve FxLightShaftInteriorDawn { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftSpotlightDawn")] 		public SSimpleCurve FxLightShaftSpotlightDawn { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftReflectionLightDawn")] 		public SSimpleCurve FxLightShaftReflectionLightDawn { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftInteriorNoon")] 		public SSimpleCurve FxLightShaftInteriorNoon { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftSpotlightNoon")] 		public SSimpleCurve FxLightShaftSpotlightNoon { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftReflectionLightNoon")] 		public SSimpleCurve FxLightShaftReflectionLightNoon { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftInteriorEvening")] 		public SSimpleCurve FxLightShaftInteriorEvening { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftSpotlightEvening")] 		public SSimpleCurve FxLightShaftSpotlightEvening { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftReflectionLightEvening")] 		public SSimpleCurve FxLightShaftReflectionLightEvening { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftInteriorNight")] 		public SSimpleCurve FxLightShaftInteriorNight { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftSpotlightNight")] 		public SSimpleCurve FxLightShaftSpotlightNight { get; set;}

		[Ordinal(0)] [RED("("fxLightShaftReflectionLightNight")] 		public SSimpleCurve FxLightShaftReflectionLightNight { get; set;}

		[Ordinal(0)] [RED("("activatedCustom0")] 		public CBool ActivatedCustom0 { get; set;}

		[Ordinal(0)] [RED("("customGroup0")] 		public SSimpleCurve CustomGroup0 { get; set;}

		[Ordinal(0)] [RED("("activatedCustom1")] 		public CBool ActivatedCustom1 { get; set;}

		[Ordinal(0)] [RED("("customGroup1")] 		public SSimpleCurve CustomGroup1 { get; set;}

		[Ordinal(0)] [RED("("activatedCustom2")] 		public CBool ActivatedCustom2 { get; set;}

		[Ordinal(0)] [RED("("customGroup2")] 		public SSimpleCurve CustomGroup2 { get; set;}

		public CEnvColorGroupsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvColorGroupsParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}