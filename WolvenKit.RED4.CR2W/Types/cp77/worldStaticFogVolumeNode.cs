using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticFogVolumeNode : worldNode
	{
		private CUInt8 _priority;
		private CBool _absolute;
		private CBool _applyHeightFalloff;
		private CFloat _densityFalloff;
		private CFloat _blendFalloff;
		private CFloat _densityFactor;
		private CFloat _absorption;
		private CFloat _streamingDistance;
		private CFloat _ambientScale;
		private CEnum<EEnvColorGroup> _envColorGroup;
		private CColor _color;
		private CEnum<rendLightChannel> _lightChannels;

		[Ordinal(4)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(5)] 
		[RED("absolute")] 
		public CBool Absolute
		{
			get => GetProperty(ref _absolute);
			set => SetProperty(ref _absolute, value);
		}

		[Ordinal(6)] 
		[RED("applyHeightFalloff")] 
		public CBool ApplyHeightFalloff
		{
			get => GetProperty(ref _applyHeightFalloff);
			set => SetProperty(ref _applyHeightFalloff, value);
		}

		[Ordinal(7)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get => GetProperty(ref _densityFalloff);
			set => SetProperty(ref _densityFalloff, value);
		}

		[Ordinal(8)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get => GetProperty(ref _blendFalloff);
			set => SetProperty(ref _blendFalloff, value);
		}

		[Ordinal(9)] 
		[RED("densityFactor")] 
		public CFloat DensityFactor
		{
			get => GetProperty(ref _densityFactor);
			set => SetProperty(ref _densityFactor, value);
		}

		[Ordinal(10)] 
		[RED("absorption")] 
		public CFloat Absorption
		{
			get => GetProperty(ref _absorption);
			set => SetProperty(ref _absorption, value);
		}

		[Ordinal(11)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		[Ordinal(12)] 
		[RED("ambientScale")] 
		public CFloat AmbientScale
		{
			get => GetProperty(ref _ambientScale);
			set => SetProperty(ref _ambientScale, value);
		}

		[Ordinal(13)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetProperty(ref _envColorGroup);
			set => SetProperty(ref _envColorGroup, value);
		}

		[Ordinal(14)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(15)] 
		[RED("lightChannels")] 
		public CEnum<rendLightChannel> LightChannels
		{
			get => GetProperty(ref _lightChannels);
			set => SetProperty(ref _lightChannels, value);
		}

		public worldStaticFogVolumeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
