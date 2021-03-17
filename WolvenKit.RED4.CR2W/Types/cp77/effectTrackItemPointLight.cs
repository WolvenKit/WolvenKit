using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemPointLight : effectTrackItem
	{
		private effectEffectParameterEvaluatorColor _tint;
		private effectEffectParameterEvaluatorFloat _intensity;
		private CFloat _eV;
		private effectEffectParameterEvaluatorFloat _radius;
		private Vector3 _offset;
		private CColor _color;
		private CEnum<EEnvColorGroup> _envColorGroup;
		private CUInt8 _colorGroupSaturation;
		private CInt8 _roughnessBias;
		private CBool _useInGI;
		private CBool _useInVolFog;
		private CBool _useInTransparents;
		private CBool _useInParticles;
		private CBool _sceneDiffuse;
		private CBool _sceneSpecular;
		private CBool _clampAttenuation;
		private rendSLightFlickering _flicker;

		[Ordinal(3)] 
		[RED("tint")] 
		public effectEffectParameterEvaluatorColor Tint
		{
			get => GetProperty(ref _tint);
			set => SetProperty(ref _tint, value);
		}

		[Ordinal(4)] 
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(5)] 
		[RED("EV")] 
		public CFloat EV
		{
			get => GetProperty(ref _eV);
			set => SetProperty(ref _eV, value);
		}

		[Ordinal(6)] 
		[RED("radius")] 
		public effectEffectParameterEvaluatorFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(7)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(8)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(9)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetProperty(ref _envColorGroup);
			set => SetProperty(ref _envColorGroup, value);
		}

		[Ordinal(10)] 
		[RED("colorGroupSaturation")] 
		public CUInt8 ColorGroupSaturation
		{
			get => GetProperty(ref _colorGroupSaturation);
			set => SetProperty(ref _colorGroupSaturation, value);
		}

		[Ordinal(11)] 
		[RED("roughnessBias")] 
		public CInt8 RoughnessBias
		{
			get => GetProperty(ref _roughnessBias);
			set => SetProperty(ref _roughnessBias, value);
		}

		[Ordinal(12)] 
		[RED("useInGI")] 
		public CBool UseInGI
		{
			get => GetProperty(ref _useInGI);
			set => SetProperty(ref _useInGI, value);
		}

		[Ordinal(13)] 
		[RED("useInVolFog")] 
		public CBool UseInVolFog
		{
			get => GetProperty(ref _useInVolFog);
			set => SetProperty(ref _useInVolFog, value);
		}

		[Ordinal(14)] 
		[RED("useInTransparents")] 
		public CBool UseInTransparents
		{
			get => GetProperty(ref _useInTransparents);
			set => SetProperty(ref _useInTransparents, value);
		}

		[Ordinal(15)] 
		[RED("useInParticles")] 
		public CBool UseInParticles
		{
			get => GetProperty(ref _useInParticles);
			set => SetProperty(ref _useInParticles, value);
		}

		[Ordinal(16)] 
		[RED("sceneDiffuse")] 
		public CBool SceneDiffuse
		{
			get => GetProperty(ref _sceneDiffuse);
			set => SetProperty(ref _sceneDiffuse, value);
		}

		[Ordinal(17)] 
		[RED("sceneSpecular")] 
		public CBool SceneSpecular
		{
			get => GetProperty(ref _sceneSpecular);
			set => SetProperty(ref _sceneSpecular, value);
		}

		[Ordinal(18)] 
		[RED("clampAttenuation")] 
		public CBool ClampAttenuation
		{
			get => GetProperty(ref _clampAttenuation);
			set => SetProperty(ref _clampAttenuation, value);
		}

		[Ordinal(19)] 
		[RED("flicker")] 
		public rendSLightFlickering Flicker
		{
			get => GetProperty(ref _flicker);
			set => SetProperty(ref _flicker, value);
		}

		public effectTrackItemPointLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
