using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAnimationOverrideMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("animationOverrides")] 
		public CHandle<audioAnimationOverrideDictionary> AnimationOverrides
		{
			get => GetPropertyValue<CHandle<audioAnimationOverrideDictionary>>();
			set => SetPropertyValue<CHandle<audioAnimationOverrideDictionary>>(value);
		}

		public audioAnimationOverrideMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
