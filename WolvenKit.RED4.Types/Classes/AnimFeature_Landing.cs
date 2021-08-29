using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Landing : animAnimFeature
	{
		private CInt32 _type;
		private CFloat _impactSpeed;

		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("impactSpeed")] 
		public CFloat ImpactSpeed
		{
			get => GetProperty(ref _impactSpeed);
			set => SetProperty(ref _impactSpeed, value);
		}
	}
}
