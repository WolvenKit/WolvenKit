using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WaterAreaSettings : IAreaSettings
	{
		private CFloat _blurMin;
		private CFloat _blurMax;
		private CFloat _blurExponent;
		private CFloat _depth;
		private CFloat _density;
		private HDRColor _lightAbsorptionColor;
		private HDRColor _lightDecayColor;
		private rRef<CBitmapTexture> _globalWaterMask;

		[Ordinal(2)] 
		[RED("blurMin")] 
		public CFloat BlurMin
		{
			get => GetProperty(ref _blurMin);
			set => SetProperty(ref _blurMin, value);
		}

		[Ordinal(3)] 
		[RED("blurMax")] 
		public CFloat BlurMax
		{
			get => GetProperty(ref _blurMax);
			set => SetProperty(ref _blurMax, value);
		}

		[Ordinal(4)] 
		[RED("blurExponent")] 
		public CFloat BlurExponent
		{
			get => GetProperty(ref _blurExponent);
			set => SetProperty(ref _blurExponent, value);
		}

		[Ordinal(5)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}

		[Ordinal(6)] 
		[RED("density")] 
		public CFloat Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(7)] 
		[RED("lightAbsorptionColor")] 
		public HDRColor LightAbsorptionColor
		{
			get => GetProperty(ref _lightAbsorptionColor);
			set => SetProperty(ref _lightAbsorptionColor, value);
		}

		[Ordinal(8)] 
		[RED("lightDecayColor")] 
		public HDRColor LightDecayColor
		{
			get => GetProperty(ref _lightDecayColor);
			set => SetProperty(ref _lightDecayColor, value);
		}

		[Ordinal(9)] 
		[RED("globalWaterMask")] 
		public rRef<CBitmapTexture> GlobalWaterMask
		{
			get => GetProperty(ref _globalWaterMask);
			set => SetProperty(ref _globalWaterMask, value);
		}

		public WaterAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
