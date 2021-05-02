using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvColorGroupsParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("defaultGroup")] 		public SSimpleCurve DefaultGroup { get; set;}

		[Ordinal(3)] [RED("lightsDefault")] 		public SSimpleCurve LightsDefault { get; set;}

		[Ordinal(4)] [RED("lightsDawn")] 		public SSimpleCurve LightsDawn { get; set;}

		[Ordinal(5)] [RED("lightsNoon")] 		public SSimpleCurve LightsNoon { get; set;}

		[Ordinal(6)] [RED("lightsEvening")] 		public SSimpleCurve LightsEvening { get; set;}

		[Ordinal(7)] [RED("lightsNight")] 		public SSimpleCurve LightsNight { get; set;}

		[Ordinal(8)] [RED("fxDefault")] 		public SSimpleCurve FxDefault { get; set;}

		[Ordinal(9)] [RED("fxFire")] 		public SSimpleCurve FxFire { get; set;}

		[Ordinal(10)] [RED("fxFireFlares")] 		public SSimpleCurve FxFireFlares { get; set;}

		[Ordinal(11)] [RED("fxFireLight")] 		public SSimpleCurve FxFireLight { get; set;}

		[Ordinal(12)] [RED("fxSmoke")] 		public SSimpleCurve FxSmoke { get; set;}

		[Ordinal(13)] [RED("fxSmokeExplosion")] 		public SSimpleCurve FxSmokeExplosion { get; set;}

		[Ordinal(14)] [RED("fxSky")] 		public SSimpleCurve FxSky { get; set;}

		[Ordinal(15)] [RED("fxSkyAlpha")] 		public SSimpleCurve FxSkyAlpha { get; set;}

		[Ordinal(16)] [RED("fxSkyNight")] 		public SSimpleCurve FxSkyNight { get; set;}

		[Ordinal(17)] [RED("fxSkyNightAlpha")] 		public SSimpleCurve FxSkyNightAlpha { get; set;}

		[Ordinal(18)] [RED("fxSkyDawn")] 		public SSimpleCurve FxSkyDawn { get; set;}

		[Ordinal(19)] [RED("fxSkyDawnAlpha")] 		public SSimpleCurve FxSkyDawnAlpha { get; set;}

		[Ordinal(20)] [RED("fxSkyNoon")] 		public SSimpleCurve FxSkyNoon { get; set;}

		[Ordinal(21)] [RED("fxSkyNoonAlpha")] 		public SSimpleCurve FxSkyNoonAlpha { get; set;}

		[Ordinal(22)] [RED("fxSkySunset")] 		public SSimpleCurve FxSkySunset { get; set;}

		[Ordinal(23)] [RED("fxSkySunsetAlpha")] 		public SSimpleCurve FxSkySunsetAlpha { get; set;}

		[Ordinal(24)] [RED("fxSkyRain")] 		public SSimpleCurve FxSkyRain { get; set;}

		[Ordinal(25)] [RED("fxSkyRainAlpha")] 		public SSimpleCurve FxSkyRainAlpha { get; set;}

		[Ordinal(26)] [RED("mainCloudsMiddle")] 		public SSimpleCurve MainCloudsMiddle { get; set;}

		[Ordinal(27)] [RED("mainCloudsMiddleAlpha")] 		public SSimpleCurve MainCloudsMiddleAlpha { get; set;}

		[Ordinal(28)] [RED("mainCloudsFront")] 		public SSimpleCurve MainCloudsFront { get; set;}

		[Ordinal(29)] [RED("mainCloudsFrontAlpha")] 		public SSimpleCurve MainCloudsFrontAlpha { get; set;}

		[Ordinal(30)] [RED("mainCloudsBack")] 		public SSimpleCurve MainCloudsBack { get; set;}

		[Ordinal(31)] [RED("mainCloudsBackAlpha")] 		public SSimpleCurve MainCloudsBackAlpha { get; set;}

		[Ordinal(32)] [RED("mainCloudsRim")] 		public SSimpleCurve MainCloudsRim { get; set;}

		[Ordinal(33)] [RED("mainCloudsRimAlpha")] 		public SSimpleCurve MainCloudsRimAlpha { get; set;}

		[Ordinal(34)] [RED("backgroundCloudsFront")] 		public SSimpleCurve BackgroundCloudsFront { get; set;}

		[Ordinal(35)] [RED("backgroundCloudsFrontAlpha")] 		public SSimpleCurve BackgroundCloudsFrontAlpha { get; set;}

		[Ordinal(36)] [RED("backgroundCloudsBack")] 		public SSimpleCurve BackgroundCloudsBack { get; set;}

		[Ordinal(37)] [RED("backgroundCloudsBackAlpha")] 		public SSimpleCurve BackgroundCloudsBackAlpha { get; set;}

		[Ordinal(38)] [RED("backgroundHazeFront")] 		public SSimpleCurve BackgroundHazeFront { get; set;}

		[Ordinal(39)] [RED("backgroundHazeFrontAlpha")] 		public SSimpleCurve BackgroundHazeFrontAlpha { get; set;}

		[Ordinal(40)] [RED("backgroundHazeBack")] 		public SSimpleCurve BackgroundHazeBack { get; set;}

		[Ordinal(41)] [RED("backgroundHazeBackAlpha")] 		public SSimpleCurve BackgroundHazeBackAlpha { get; set;}

		[Ordinal(42)] [RED("fxBlood")] 		public SSimpleCurve FxBlood { get; set;}

		[Ordinal(43)] [RED("fxWater")] 		public SSimpleCurve FxWater { get; set;}

		[Ordinal(44)] [RED("fxFog")] 		public SSimpleCurve FxFog { get; set;}

		[Ordinal(45)] [RED("fxTrails")] 		public SSimpleCurve FxTrails { get; set;}

		[Ordinal(46)] [RED("fxScreenParticles")] 		public SSimpleCurve FxScreenParticles { get; set;}

		[Ordinal(47)] [RED("fxLightShaft")] 		public SSimpleCurve FxLightShaft { get; set;}

		[Ordinal(48)] [RED("fxLightShaftSun")] 		public SSimpleCurve FxLightShaftSun { get; set;}

		[Ordinal(49)] [RED("fxLightShaftInteriorDawn")] 		public SSimpleCurve FxLightShaftInteriorDawn { get; set;}

		[Ordinal(50)] [RED("fxLightShaftSpotlightDawn")] 		public SSimpleCurve FxLightShaftSpotlightDawn { get; set;}

		[Ordinal(51)] [RED("fxLightShaftReflectionLightDawn")] 		public SSimpleCurve FxLightShaftReflectionLightDawn { get; set;}

		[Ordinal(52)] [RED("fxLightShaftInteriorNoon")] 		public SSimpleCurve FxLightShaftInteriorNoon { get; set;}

		[Ordinal(53)] [RED("fxLightShaftSpotlightNoon")] 		public SSimpleCurve FxLightShaftSpotlightNoon { get; set;}

		[Ordinal(54)] [RED("fxLightShaftReflectionLightNoon")] 		public SSimpleCurve FxLightShaftReflectionLightNoon { get; set;}

		[Ordinal(55)] [RED("fxLightShaftInteriorEvening")] 		public SSimpleCurve FxLightShaftInteriorEvening { get; set;}

		[Ordinal(56)] [RED("fxLightShaftSpotlightEvening")] 		public SSimpleCurve FxLightShaftSpotlightEvening { get; set;}

		[Ordinal(57)] [RED("fxLightShaftReflectionLightEvening")] 		public SSimpleCurve FxLightShaftReflectionLightEvening { get; set;}

		[Ordinal(58)] [RED("fxLightShaftInteriorNight")] 		public SSimpleCurve FxLightShaftInteriorNight { get; set;}

		[Ordinal(59)] [RED("fxLightShaftSpotlightNight")] 		public SSimpleCurve FxLightShaftSpotlightNight { get; set;}

		[Ordinal(60)] [RED("fxLightShaftReflectionLightNight")] 		public SSimpleCurve FxLightShaftReflectionLightNight { get; set;}

		[Ordinal(61)] [RED("activatedCustom0")] 		public CBool ActivatedCustom0 { get; set;}

		[Ordinal(62)] [RED("customGroup0")] 		public SSimpleCurve CustomGroup0 { get; set;}

		[Ordinal(63)] [RED("activatedCustom1")] 		public CBool ActivatedCustom1 { get; set;}

		[Ordinal(64)] [RED("customGroup1")] 		public SSimpleCurve CustomGroup1 { get; set;}

		[Ordinal(65)] [RED("activatedCustom2")] 		public CBool ActivatedCustom2 { get; set;}

		[Ordinal(66)] [RED("customGroup2")] 		public SSimpleCurve CustomGroup2 { get; set;}

		public CEnvColorGroupsParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvColorGroupsParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}