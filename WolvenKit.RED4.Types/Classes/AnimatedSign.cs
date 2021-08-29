using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimatedSign : InteractiveDevice
	{
		private CHandle<AnimFeature_AnimatedDevice> _animFeature;

		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_AnimatedDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}
	}
}
