using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemPointLight : effectTrackItem
	{
		[Ordinal(0)]  [RED("EV")] public CFloat EV { get; set; }
		[Ordinal(1)]  [RED("clampAttenuation")] public CBool ClampAttenuation { get; set; }
		[Ordinal(2)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(3)]  [RED("colorGroupSaturation")] public CUInt8 ColorGroupSaturation { get; set; }
		[Ordinal(4)]  [RED("envColorGroup")] public CEnum<EEnvColorGroup> EnvColorGroup { get; set; }
		[Ordinal(5)]  [RED("flicker")] public rendSLightFlickering Flicker { get; set; }
		[Ordinal(6)]  [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
		[Ordinal(7)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(8)]  [RED("radius")] public effectEffectParameterEvaluatorFloat Radius { get; set; }
		[Ordinal(9)]  [RED("roughnessBias")] public CInt8 RoughnessBias { get; set; }
		[Ordinal(10)]  [RED("sceneDiffuse")] public CBool SceneDiffuse { get; set; }
		[Ordinal(11)]  [RED("sceneSpecular")] public CBool SceneSpecular { get; set; }
		[Ordinal(12)]  [RED("tint")] public effectEffectParameterEvaluatorColor Tint { get; set; }
		[Ordinal(13)]  [RED("useInGI")] public CBool UseInGI { get; set; }
		[Ordinal(14)]  [RED("useInParticles")] public CBool UseInParticles { get; set; }
		[Ordinal(15)]  [RED("useInTransparents")] public CBool UseInTransparents { get; set; }
		[Ordinal(16)]  [RED("useInVolFog")] public CBool UseInVolFog { get; set; }

		public effectTrackItemPointLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
