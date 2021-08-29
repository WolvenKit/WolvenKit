using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAnimationOverrideMetadata : audioAudioMetadata
	{
		private CHandle<audioAnimationOverrideDictionary> _animationOverrides;

		[Ordinal(1)] 
		[RED("animationOverrides")] 
		public CHandle<audioAnimationOverrideDictionary> AnimationOverrides
		{
			get => GetProperty(ref _animationOverrides);
			set => SetProperty(ref _animationOverrides, value);
		}
	}
}
