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
			AnimationOverrides = new audioAnimationOverrideDictionary { EntryType = new audioAnimationOverrideDictionaryItem() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
