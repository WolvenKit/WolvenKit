using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocTokenPopupCloseData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("chosenOptionIndex")] 
		public CInt32 ChosenOptionIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("chosenOptionData")] 
		public CHandle<gameItemData> ChosenOptionData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(10)] 
		[RED("costData")] 
		public CyberwareUpgradeCostData CostData
		{
			get => GetPropertyValue<CyberwareUpgradeCostData>();
			set => SetPropertyValue<CyberwareUpgradeCostData>(value);
		}

		public RipperdocTokenPopupCloseData()
		{
			CostData = new CyberwareUpgradeCostData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
