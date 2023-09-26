using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkTabsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("tabText")] 
		public inkTextWidgetReference TabText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("currentAttributePoints")] 
		public inkTextWidgetReference CurrentAttributePoints
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("currentAttributeIcon")] 
		public inkImageWidgetReference CurrentAttributeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("leftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("rightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("attributePointsWrapper")] 
		public inkWidgetReference AttributePointsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("attributePointsText")] 
		public inkTextWidgetReference AttributePointsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("perkPointsWrapper")] 
		public inkWidgetReference PerkPointsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("perkPointsText")] 
		public inkTextWidgetReference PerkPointsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("espionagePointsWrapper")] 
		public inkWidgetReference EspionagePointsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("espionagePointsText")] 
		public inkTextWidgetReference EspionagePointsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("bars")] 
		public CArray<inkWidgetReference> Bars
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(13)] 
		[RED("dataManager")] 
		public CWeakHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CWeakHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CWeakHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(14)] 
		[RED("initData")] 
		public CHandle<NewPerksScreenInitData> InitData
		{
			get => GetPropertyValue<CHandle<NewPerksScreenInitData>>();
			set => SetPropertyValue<CHandle<NewPerksScreenInitData>>(value);
		}

		[Ordinal(15)] 
		[RED("isEspionageUnlocked")] 
		public CBool IsEspionageUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewPerkTabsController()
		{
			TabText = new inkTextWidgetReference();
			CurrentAttributePoints = new inkTextWidgetReference();
			CurrentAttributeIcon = new inkImageWidgetReference();
			LeftArrow = new inkWidgetReference();
			RightArrow = new inkWidgetReference();
			AttributePointsWrapper = new inkWidgetReference();
			AttributePointsText = new inkTextWidgetReference();
			PerkPointsWrapper = new inkWidgetReference();
			PerkPointsText = new inkTextWidgetReference();
			EspionagePointsWrapper = new inkWidgetReference();
			EspionagePointsText = new inkTextWidgetReference();
			Bars = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
