using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetChargeEvents : CombatGadgetTransitions
	{
		[Ordinal(0)] 
		[RED("initiated")] 
		public CBool Initiated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("itemSwitched")] 
		public CBool ItemSwitched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
