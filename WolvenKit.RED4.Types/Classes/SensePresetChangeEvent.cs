using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SensePresetChangeEvent : senseVisibilityEvent
	{
		[Ordinal(4)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("mainPreset")] 
		public CBool MainPreset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SensePresetChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
