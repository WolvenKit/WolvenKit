using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvColorGroupsParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("defaultGroup")] 		public SSimpleCurve DefaultGroup { get; set;}

		[RED("lightsDefault")] 		public SSimpleCurve LightsDefault { get; set;}

		[RED("lightsDawn")] 		public SSimpleCurve LightsDawn { get; set;}

		[RED("lightsNoon")] 		public SSimpleCurve LightsNoon { get; set;}

		[RED("lightsEvening")] 		public SSimpleCurve LightsEvening { get; set;}

		[RED("lightsNight")] 		public SSimpleCurve LightsNight { get; set;}

		[RED("fxDefault")] 		public SSimpleCurve FxDefault { get; set;}

		[RED("fxFire")] 		public SSimpleCurve FxFire { get; set;}

		[RED("fxFireFlares")] 		public SSimpleCurve FxFireFlares { get; set;}

		[RED("fxFireLight")] 		public SSimpleCurve FxFireLight { get; set;}

		[RED("fxSmoke")] 		public SSimpleCurve FxSmoke { get; set;}

		[RED("fxSmokeExplosion")] 		public SSimpleCurve FxSmokeExplosion { get; set;}

		[RED("fxSky")] 		public SSimpleCurve FxSky { get; set;}

		[RED("fxSkyAlpha")] 		public SSimpleCurve FxSkyAlpha { get; set;}

		[RED("fxSkyNight")] 		public SSimpleCurve FxSkyNight { get; set;}

		[RED("fxSkyNightAlpha")] 		public SSimpleCurve FxSkyNightAlpha { get; set;}

		[RED("fxSkyDawn")] 		public SSimpleCurve FxSkyDawn { get; set;}

		[RED("fxSkyDawnAlpha")] 		public SSimpleCurve FxSkyDawnAlpha { get; set;}

		[RED("fxSkyNoon")] 		public SSimpleCurve FxSkyNoon { get; set;}

		[RED("fxSkyNoonAlpha")] 		public SSimpleCurve FxSkyNoonAlpha { get; set;}

		[RED("fxSkySunset")] 		public SSimpleCurve FxSkySunset { get; set;}

		[RED("fxSkySunsetAlpha")] 		public SSimpleCurve FxSkySunsetAlpha { get; set;}

		[RED("fxSkyRain")] 		public SSimpleCurve FxSkyRain { get; set;}

		[RED("fxSkyRainAlpha")] 		public SSimpleCurve FxSkyRainAlpha { get; set;}

		[RED("mainCloudsMiddle")] 		public SSimpleCurve MainCloudsMiddle { get; set;}

		[RED("mainCloudsMiddleAlpha")] 		public SSimpleCurve MainCloudsMiddleAlpha { get; set;}

		[RED("mainCloudsFront")] 		public SSimpleCurve MainCloudsFront { get; set;}

		[RED("mainCloudsFrontAlpha")] 		public SSimpleCurve MainCloudsFrontAlpha { get; set;}

		[RED("mainCloudsBack")] 		public SSimpleCurve MainCloudsBack { get; set;}

		[RED("mainCloudsBackAlpha")] 		public SSimpleCurve MainCloudsBackAlpha { get; set;}

		[RED("mainCloudsRim")] 		public SSimpleCurve MainCloudsRim { get; set;}

		[RED("mainCloudsRimAlpha")] 		public SSimpleCurve MainCloudsRimAlpha { get; set;}

		[RED("backgroundCloudsFront")] 		public SSimpleCurve BackgroundCloudsFront { get; set;}

		[RED("backgroundCloudsFrontAlpha")] 		public SSimpleCurve BackgroundCloudsFrontAlpha { get; set;}

		[RED("backgroundCloudsBack")] 		public SSimpleCurve BackgroundCloudsBack { get; set;}

		[RED("backgroundCloudsBackAlpha")] 		public SSimpleCurve BackgroundCloudsBackAlpha { get; set;}

		[RED("backgroundHazeFront")] 		public SSimpleCurve BackgroundHazeFront { get; set;}

		[RED("backgroundHazeFrontAlpha")] 		public SSimpleCurve BackgroundHazeFrontAlpha { get; set;}

		[RED("backgroundHazeBack")] 		public SSimpleCurve BackgroundHazeBack { get; set;}

		[RED("backgroundHazeBackAlpha")] 		public SSimpleCurve BackgroundHazeBackAlpha { get; set;}

		[RED("fxBlood")] 		public SSimpleCurve FxBlood { get; set;}

		[RED("fxWater")] 		public SSimpleCurve FxWater { get; set;}

		[RED("fxFog")] 		public SSimpleCurve FxFog { get; set;}

		[RED("fxTrails")] 		public SSimpleCurve FxTrails { get; set;}

		[RED("fxScreenParticles")] 		public SSimpleCurve FxScreenParticles { get; set;}

		[RED("fxLightShaft")] 		public SSimpleCurve FxLightShaft { get; set;}

		[RED("fxLightShaftSun")] 		public SSimpleCurve FxLightShaftSun { get; set;}

		[RED("fxLightShaftInteriorDawn")] 		public SSimpleCurve FxLightShaftInteriorDawn { get; set;}

		[RED("fxLightShaftSpotlightDawn")] 		public SSimpleCurve FxLightShaftSpotlightDawn { get; set;}

		[RED("fxLightShaftReflectionLightDawn")] 		public SSimpleCurve FxLightShaftReflectionLightDawn { get; set;}

		[RED("fxLightShaftInteriorNoon")] 		public SSimpleCurve FxLightShaftInteriorNoon { get; set;}

		[RED("fxLightShaftSpotlightNoon")] 		public SSimpleCurve FxLightShaftSpotlightNoon { get; set;}

		[RED("fxLightShaftReflectionLightNoon")] 		public SSimpleCurve FxLightShaftReflectionLightNoon { get; set;}

		[RED("fxLightShaftInteriorEvening")] 		public SSimpleCurve FxLightShaftInteriorEvening { get; set;}

		[RED("fxLightShaftSpotlightEvening")] 		public SSimpleCurve FxLightShaftSpotlightEvening { get; set;}

		[RED("fxLightShaftReflectionLightEvening")] 		public SSimpleCurve FxLightShaftReflectionLightEvening { get; set;}

		[RED("fxLightShaftInteriorNight")] 		public SSimpleCurve FxLightShaftInteriorNight { get; set;}

		[RED("fxLightShaftSpotlightNight")] 		public SSimpleCurve FxLightShaftSpotlightNight { get; set;}

		[RED("fxLightShaftReflectionLightNight")] 		public SSimpleCurve FxLightShaftReflectionLightNight { get; set;}

		[RED("activatedCustom0")] 		public CBool ActivatedCustom0 { get; set;}

		[RED("customGroup0")] 		public SSimpleCurve CustomGroup0 { get; set;}

		[RED("activatedCustom1")] 		public CBool ActivatedCustom1 { get; set;}

		[RED("customGroup1")] 		public SSimpleCurve CustomGroup1 { get; set;}

		[RED("activatedCustom2")] 		public CBool ActivatedCustom2 { get; set;}

		[RED("customGroup2")] 		public SSimpleCurve CustomGroup2 { get; set;}

		public CEnvColorGroupsParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvColorGroupsParameters(cr2w);

	}
}