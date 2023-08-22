using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationStatsMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] 
		[RED("attribute_01")] 
		public inkWidgetReference Attribute_01
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("attribute_02")] 
		public inkWidgetReference Attribute_02
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("attribute_03")] 
		public inkWidgetReference Attribute_03
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("attribute_04")] 
		public inkWidgetReference Attribute_04
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("attribute_05")] 
		public inkWidgetReference Attribute_05
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("pointsLabel")] 
		public inkWidgetReference PointsLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("tooltipSlot")] 
		public inkWidgetReference TooltipSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("skillPointLabel")] 
		public inkTextWidgetReference SkillPointLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("reset")] 
		public inkWidgetReference Reset
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("nextMenuConfirmation")] 
		public inkWidgetReference NextMenuConfirmation
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("nextMenukConfirmationLibraryWidget")] 
		public inkWidgetReference NextMenukConfirmationLibraryWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("attributesControllers")] 
		public CArray<CWeakHandle<characterCreationStatsAttributeBtn>> AttributesControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<characterCreationStatsAttributeBtn>>>();
			set => SetPropertyValue<CArray<CWeakHandle<characterCreationStatsAttributeBtn>>>(value);
		}

		[Ordinal(24)] 
		[RED("attributePointsAvailable")] 
		public CInt32 AttributePointsAvailable
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("startingAttributePoints")] 
		public CInt32 StartingAttributePoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(27)] 
		[RED("toolTipOffset")] 
		public inkMargin ToolTipOffset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(30)] 
		[RED("hoverdWidget")] 
		public CWeakHandle<inkWidget> HoverdWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public CharacterCreationStatsMenu()
		{
			Attribute_01 = new inkWidgetReference();
			Attribute_02 = new inkWidgetReference();
			Attribute_03 = new inkWidgetReference();
			Attribute_04 = new inkWidgetReference();
			Attribute_05 = new inkWidgetReference();
			PointsLabel = new inkWidgetReference();
			TooltipSlot = new inkWidgetReference();
			SkillPointLabel = new inkTextWidgetReference();
			Reset = new inkWidgetReference();
			NextMenuConfirmation = new inkWidgetReference();
			NextMenukConfirmationLibraryWidget = new inkWidgetReference();
			ConfirmationConfirmBtn = new inkWidgetReference();
			ConfirmationCloseBtn = new inkWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();
			PreviousPageBtn = new inkWidgetReference();
			NavigationButtons = new inkWidgetReference();
			OptionSwitchHint = new inkWidgetReference();
			AttributesControllers = new();
			ToolTipOffset = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
