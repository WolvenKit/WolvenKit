using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KeyBindings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("DPAD_UP")] 
		public TweakDBID DPAD_UP
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("RB")] 
		public TweakDBID RB
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public KeyBindings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
