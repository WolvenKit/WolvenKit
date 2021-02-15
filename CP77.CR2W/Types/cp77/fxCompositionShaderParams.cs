using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class fxCompositionShaderParams : CVariable
	{
		[Ordinal(0)] [RED("glitchParam")] public CFloat GlitchParam { get; set; }
		[Ordinal(1)] [RED("glitchParam1")] public CFloat GlitchParam1 { get; set; }
		[Ordinal(2)] [RED("health")] public CFloat Health { get; set; }
		[Ordinal(3)] [RED("visionActiveTime")] public CFloat VisionActiveTime { get; set; }
		[Ordinal(4)] [RED("uiFactor")] public CFloat UiFactor { get; set; }
		[Ordinal(5)] [RED("uiPassthroughFactor")] public CFloat UiPassthroughFactor { get; set; }
		[Ordinal(6)] [RED("mainRenderFactor")] public CFloat MainRenderFactor { get; set; }
		[Ordinal(7)] [RED("blurredRenderFactor")] public CFloat BlurredRenderFactor { get; set; }
		[Ordinal(8)] [RED("backgroundTextureFactor")] public CFloat BackgroundTextureFactor { get; set; }
		[Ordinal(9)] [RED("backgroundBlurRadius")] public CFloat BackgroundBlurRadius { get; set; }
		[Ordinal(10)] [RED("sphericalDistPower")] public Vector2 SphericalDistPower { get; set; }
		[Ordinal(11)] [RED("shadowDistance")] public Vector2 ShadowDistance { get; set; }
		[Ordinal(12)] [RED("shadowIntensity")] public CFloat ShadowIntensity { get; set; }
		[Ordinal(13)] [RED("shadowRadius")] public CFloat ShadowRadius { get; set; }
		[Ordinal(14)] [RED("glowIntensity")] public CFloat GlowIntensity { get; set; }
		[Ordinal(15)] [RED("glowTresholdStart")] public CFloat GlowTresholdStart { get; set; }
		[Ordinal(16)] [RED("glowTresholdEnd")] public CFloat GlowTresholdEnd { get; set; }
		[Ordinal(17)] [RED("glowBlurRadius")] public CFloat GlowBlurRadius { get; set; }
		[Ordinal(18)] [RED("vignetteStart")] public CFloat VignetteStart { get; set; }
		[Ordinal(19)] [RED("vignetteEnd")] public CFloat VignetteEnd { get; set; }
		[Ordinal(20)] [RED("vignetteIntensity")] public CFloat VignetteIntensity { get; set; }
		[Ordinal(21)] [RED("blurredRenderSaturation")] public CFloat BlurredRenderSaturation { get; set; }
		[Ordinal(22)] [RED("uiSaturation")] public CFloat UiSaturation { get; set; }
		[Ordinal(23)] [RED("chromaticAberrationStrength")] public CFloat ChromaticAberrationStrength { get; set; }
		[Ordinal(24)] [RED("uiLayer2Scale")] public Vector2 UiLayer2Scale { get; set; }
		[Ordinal(25)] [RED("uiLayer3Scale")] public Vector2 UiLayer3Scale { get; set; }
		[Ordinal(26)] [RED("uiLayer4Scale")] public Vector2 UiLayer4Scale { get; set; }
		[Ordinal(27)] [RED("uiLayer2Weight")] public CFloat UiLayer2Weight { get; set; }
		[Ordinal(28)] [RED("uiLayer3Weight")] public CFloat UiLayer3Weight { get; set; }
		[Ordinal(29)] [RED("uiLayer4Weight")] public CFloat UiLayer4Weight { get; set; }

		public fxCompositionShaderParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
