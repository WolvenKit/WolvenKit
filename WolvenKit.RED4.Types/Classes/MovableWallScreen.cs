using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableWallScreen : Door
	{
		private CFloat _animationLength;
		private CHandle<AnimFeature_SimpleDevice> _animFeature;

		[Ordinal(140)] 
		[RED("animationLength")] 
		public CFloat AnimationLength
		{
			get => GetProperty(ref _animationLength);
			set => SetProperty(ref _animationLength, value);
		}

		[Ordinal(141)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}
	}
}
