using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetChargeEvents : CombatGadgetTransitions
	{
		private CBool _initiated;
		private CBool _itemSwitched;

		[Ordinal(0)] 
		[RED("initiated")] 
		public CBool Initiated
		{
			get => GetProperty(ref _initiated);
			set => SetProperty(ref _initiated, value);
		}

		[Ordinal(1)] 
		[RED("itemSwitched")] 
		public CBool ItemSwitched
		{
			get => GetProperty(ref _itemSwitched);
			set => SetProperty(ref _itemSwitched, value);
		}
	}
}
