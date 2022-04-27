using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksMenuAttributeItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("attributeDisplay")] 
		public inkWidgetReference AttributeDisplay
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("connectionLine")] 
		public inkImageWidgetReference ConnectionLine
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		[Ordinal(4)] 
		[RED("skillsLevelsContainer")] 
		public inkCompoundWidgetReference SkillsLevelsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("proficiencyButtonRefs")] 
		public CArray<inkWidgetReference> ProficiencyButtonRefs
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(6)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(8)] 
		[RED("attributeDisplayController")] 
		public CWeakHandle<PerksMenuAttributeDisplayController> AttributeDisplayController
		{
			get => GetPropertyValue<CWeakHandle<PerksMenuAttributeDisplayController>>();
			set => SetPropertyValue<CWeakHandle<PerksMenuAttributeDisplayController>>(value);
		}

		[Ordinal(9)] 
		[RED("recentlyPurchased")] 
		public CBool RecentlyPurchased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("holdStarted")] 
		public CBool HoldStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<AttributeData> Data
		{
			get => GetPropertyValue<CHandle<AttributeData>>();
			set => SetPropertyValue<CHandle<AttributeData>>(value);
		}

		[Ordinal(12)] 
		[RED("cool_in_proxy")] 
		public CHandle<inkanimProxy> Cool_in_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("cool_out_proxy")] 
		public CHandle<inkanimProxy> Cool_out_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PerksMenuAttributeItemController()
		{
			AttributeDisplay = new();
			ConnectionLine = new();
			SkillsLevelsContainer = new();
			ProficiencyButtonRefs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
