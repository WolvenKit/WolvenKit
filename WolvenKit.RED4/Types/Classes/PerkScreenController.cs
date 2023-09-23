using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkScreenController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("hubSelector")] 
		public inkWidgetReference HubSelector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("connectionLinesContainer")] 
		public inkCompoundWidgetReference ConnectionLinesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("boughtConnectionLinesContainer")] 
		public inkCompoundWidgetReference BoughtConnectionLinesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("maxedConnectionLinesContainer")] 
		public inkCompoundWidgetReference MaxedConnectionLinesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("boughtMaskContainer")] 
		public inkCanvasWidgetReference BoughtMaskContainer
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("maxedMaskContainer")] 
		public inkCanvasWidgetReference MaxedMaskContainer
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("attributeNameText")] 
		public inkTextWidgetReference AttributeNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("attributeLevelText")] 
		public inkTextWidgetReference AttributeLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("levelControllerRef")] 
		public inkWidgetReference LevelControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("rewardsControllerRef")] 
		public inkWidgetReference RewardsControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("proficiencyRootRef")] 
		public inkWidgetReference ProficiencyRootRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("proficiencyDescriptionText")] 
		public inkTextWidgetReference ProficiencyDescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(15)] 
		[RED("displayData")] 
		public CHandle<AttributeDisplayData> DisplayData
		{
			get => GetPropertyValue<CHandle<AttributeDisplayData>>();
			set => SetPropertyValue<CHandle<AttributeDisplayData>>(value);
		}

		[Ordinal(16)] 
		[RED("proficiencyRoot")] 
		public CWeakHandle<TabRadioGroup> ProficiencyRoot
		{
			get => GetPropertyValue<CWeakHandle<TabRadioGroup>>();
			set => SetPropertyValue<CWeakHandle<TabRadioGroup>>(value);
		}

		[Ordinal(17)] 
		[RED("widgetMap")] 
		public CArray<CWeakHandle<PerkDisplayContainerController>> WidgetMap
		{
			get => GetPropertyValue<CArray<CWeakHandle<PerkDisplayContainerController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<PerkDisplayContainerController>>>(value);
		}

		[Ordinal(18)] 
		[RED("traitController")] 
		public CWeakHandle<PerkDisplayContainerController> TraitController
		{
			get => GetPropertyValue<CWeakHandle<PerkDisplayContainerController>>();
			set => SetPropertyValue<CWeakHandle<PerkDisplayContainerController>>(value);
		}

		[Ordinal(19)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("connectionLines", 45)] 
		public CArrayFixedSize<CInt32> ConnectionLines
		{
			get => GetPropertyValue<CArrayFixedSize<CInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CInt32>>(value);
		}

		[Ordinal(21)] 
		[RED("levelController")] 
		public CWeakHandle<StatsProgressController> LevelController
		{
			get => GetPropertyValue<CWeakHandle<StatsProgressController>>();
			set => SetPropertyValue<CWeakHandle<StatsProgressController>>(value);
		}

		[Ordinal(22)] 
		[RED("rewardsController")] 
		public CWeakHandle<StatsStreetCredReward> RewardsController
		{
			get => GetPropertyValue<CWeakHandle<StatsStreetCredReward>>();
			set => SetPropertyValue<CWeakHandle<StatsStreetCredReward>>(value);
		}

		[Ordinal(23)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		public PerkScreenController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
