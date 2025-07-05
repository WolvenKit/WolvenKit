using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SoundSystemSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("interactionName")] 
		public TweakDBID InteractionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("musicSettings")] 
		public CHandle<MusicSettings> MusicSettings
		{
			get => GetPropertyValue<CHandle<MusicSettings>>();
			set => SetPropertyValue<CHandle<MusicSettings>>(value);
		}

		[Ordinal(2)] 
		[RED("canBeUsedAsQuickHack")] 
		public CBool CanBeUsedAsQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SoundSystemSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
