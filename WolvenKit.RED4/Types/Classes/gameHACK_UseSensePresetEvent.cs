using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHACK_UseSensePresetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sensePreset")] 
		public TweakDBID SensePreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameHACK_UseSensePresetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
