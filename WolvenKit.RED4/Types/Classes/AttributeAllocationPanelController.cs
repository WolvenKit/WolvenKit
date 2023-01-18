using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeAllocationPanelController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("allocationPointsContainer")] 
		public inkCompoundWidgetReference AllocationPointsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("armorAmountText")] 
		public inkTextWidgetReference ArmorAmountText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("tokenAmountText")] 
		public inkTextWidgetReference TokenAmountText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("allocationData")] 
		public CArray<CHandle<AttributeAllocationData>> AllocationData
		{
			get => GetPropertyValue<CArray<CHandle<AttributeAllocationData>>>();
			set => SetPropertyValue<CArray<CHandle<AttributeAllocationData>>>(value);
		}

		[Ordinal(7)] 
		[RED("allocationWidgets")] 
		public CArray<CWeakHandle<AttributeAllocationController>> AllocationWidgets
		{
			get => GetPropertyValue<CArray<CWeakHandle<AttributeAllocationController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<AttributeAllocationController>>>(value);
		}

		[Ordinal(8)] 
		[RED("statsSystem")] 
		public CWeakHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CWeakHandle<gameStatsSystem>>();
			set => SetPropertyValue<CWeakHandle<gameStatsSystem>>(value);
		}

		[Ordinal(9)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(10)] 
		[RED("useAlternativeSwitch")] 
		public CBool UseAlternativeSwitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("ripperdocTokenManager")] 
		public CHandle<RipperdocTokenManager> RipperdocTokenManager
		{
			get => GetPropertyValue<CHandle<RipperdocTokenManager>>();
			set => SetPropertyValue<CHandle<RipperdocTokenManager>>(value);
		}

		public AttributeAllocationPanelController()
		{
			AllocationPointsContainer = new();
			ArmorAmountText = new();
			TokenAmountText = new();
			AllocationData = new();
			AllocationWidgets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
