using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleSwitchControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("switchAction")] 
		public CEnum<ESwitchAction> SwitchAction
		{
			get => GetPropertyValue<CEnum<ESwitchAction>>();
			set => SetPropertyValue<CEnum<ESwitchAction>>(value);
		}

		[Ordinal(106)] 
		[RED("nameForON")] 
		public TweakDBID NameForON
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(107)] 
		[RED("nameForOFF")] 
		public TweakDBID NameForOFF
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SimpleSwitchControllerPS()
		{
			DeviceName = "LocKey#115";
			TweakDBRecord = new() { Value = 87940692723 };
			TweakDBDescriptionRecord = new() { Value = 138796611214 };
		}
	}
}
