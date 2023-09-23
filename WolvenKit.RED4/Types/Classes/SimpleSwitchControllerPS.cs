using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleSwitchControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("switchAction")] 
		public CEnum<ESwitchAction> SwitchAction
		{
			get => GetPropertyValue<CEnum<ESwitchAction>>();
			set => SetPropertyValue<CEnum<ESwitchAction>>(value);
		}

		[Ordinal(109)] 
		[RED("nameForON")] 
		public TweakDBID NameForON
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(110)] 
		[RED("nameForOFF")] 
		public TweakDBID NameForOFF
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SimpleSwitchControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
