using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDynamicDecal : effectTrackItem
	{
		private rRef<IMaterial> _material;
		private CFloat _width;
		private CFloat _height;
		private CFloat _fadeInTime;
		private CFloat _fadeOutTime;
		private CFloat _additionalRotation;
		private CBool _randomRotation;

		[Ordinal(3)] 
		[RED("material")] 
		public rRef<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(6)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get => GetProperty(ref _fadeInTime);
			set => SetProperty(ref _fadeInTime, value);
		}

		[Ordinal(7)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get => GetProperty(ref _fadeOutTime);
			set => SetProperty(ref _fadeOutTime, value);
		}

		[Ordinal(8)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get => GetProperty(ref _additionalRotation);
			set => SetProperty(ref _additionalRotation, value);
		}

		[Ordinal(9)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get => GetProperty(ref _randomRotation);
			set => SetProperty(ref _randomRotation, value);
		}

		public effectTrackItemDynamicDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
