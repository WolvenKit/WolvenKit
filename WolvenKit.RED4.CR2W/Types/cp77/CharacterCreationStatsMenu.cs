using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationStatsMenu : gameuiBaseCharacterCreationController
	{
		private inkWidgetReference _attribute_01;
		private inkWidgetReference _attribute_02;
		private inkWidgetReference _attribute_03;
		private inkWidgetReference _attribute_04;
		private inkWidgetReference _attribute_05;
		private inkWidgetReference _pointsLabel;
		private inkWidgetReference _tooltipSlot;
		private inkTextWidgetReference _skillPointLabel;
		private inkWidgetReference _reset;
		private inkWidgetReference _nextMenuConfirmation;
		private inkWidgetReference _nextMenukConfirmationLibraryWidget;
		private inkWidgetReference _confirmationConfirmBtn;
		private inkWidgetReference _confirmationCloseBtn;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _previousPageBtn;
		private inkWidgetReference _navigationButtons;
		private inkWidgetReference _optionSwitchHint;
		private CArray<CHandle<characterCreationStatsAttributeBtn>> _attributesControllers;
		private CInt32 _attributePointsAvailable;
		private CInt32 _startingAttributePoints;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private inkMargin _toolTipOffset;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _confirmAnimationProxy;
		private wCHandle<inkWidget> _hoverdWidget;

		[Ordinal(6)] 
		[RED("attribute_01")] 
		public inkWidgetReference Attribute_01
		{
			get => GetProperty(ref _attribute_01);
			set => SetProperty(ref _attribute_01, value);
		}

		[Ordinal(7)] 
		[RED("attribute_02")] 
		public inkWidgetReference Attribute_02
		{
			get => GetProperty(ref _attribute_02);
			set => SetProperty(ref _attribute_02, value);
		}

		[Ordinal(8)] 
		[RED("attribute_03")] 
		public inkWidgetReference Attribute_03
		{
			get => GetProperty(ref _attribute_03);
			set => SetProperty(ref _attribute_03, value);
		}

		[Ordinal(9)] 
		[RED("attribute_04")] 
		public inkWidgetReference Attribute_04
		{
			get => GetProperty(ref _attribute_04);
			set => SetProperty(ref _attribute_04, value);
		}

		[Ordinal(10)] 
		[RED("attribute_05")] 
		public inkWidgetReference Attribute_05
		{
			get => GetProperty(ref _attribute_05);
			set => SetProperty(ref _attribute_05, value);
		}

		[Ordinal(11)] 
		[RED("pointsLabel")] 
		public inkWidgetReference PointsLabel
		{
			get => GetProperty(ref _pointsLabel);
			set => SetProperty(ref _pointsLabel, value);
		}

		[Ordinal(12)] 
		[RED("tooltipSlot")] 
		public inkWidgetReference TooltipSlot
		{
			get => GetProperty(ref _tooltipSlot);
			set => SetProperty(ref _tooltipSlot, value);
		}

		[Ordinal(13)] 
		[RED("skillPointLabel")] 
		public inkTextWidgetReference SkillPointLabel
		{
			get => GetProperty(ref _skillPointLabel);
			set => SetProperty(ref _skillPointLabel, value);
		}

		[Ordinal(14)] 
		[RED("reset")] 
		public inkWidgetReference Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}

		[Ordinal(15)] 
		[RED("nextMenuConfirmation")] 
		public inkWidgetReference NextMenuConfirmation
		{
			get => GetProperty(ref _nextMenuConfirmation);
			set => SetProperty(ref _nextMenuConfirmation, value);
		}

		[Ordinal(16)] 
		[RED("nextMenukConfirmationLibraryWidget")] 
		public inkWidgetReference NextMenukConfirmationLibraryWidget
		{
			get => GetProperty(ref _nextMenukConfirmationLibraryWidget);
			set => SetProperty(ref _nextMenukConfirmationLibraryWidget, value);
		}

		[Ordinal(17)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get => GetProperty(ref _confirmationConfirmBtn);
			set => SetProperty(ref _confirmationConfirmBtn, value);
		}

		[Ordinal(18)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get => GetProperty(ref _confirmationCloseBtn);
			set => SetProperty(ref _confirmationCloseBtn, value);
		}

		[Ordinal(19)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(20)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetProperty(ref _previousPageBtn);
			set => SetProperty(ref _previousPageBtn, value);
		}

		[Ordinal(21)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get => GetProperty(ref _navigationButtons);
			set => SetProperty(ref _navigationButtons, value);
		}

		[Ordinal(22)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetProperty(ref _optionSwitchHint);
			set => SetProperty(ref _optionSwitchHint, value);
		}

		[Ordinal(23)] 
		[RED("attributesControllers")] 
		public CArray<CHandle<characterCreationStatsAttributeBtn>> AttributesControllers
		{
			get => GetProperty(ref _attributesControllers);
			set => SetProperty(ref _attributesControllers, value);
		}

		[Ordinal(24)] 
		[RED("attributePointsAvailable")] 
		public CInt32 AttributePointsAvailable
		{
			get => GetProperty(ref _attributePointsAvailable);
			set => SetProperty(ref _attributePointsAvailable, value);
		}

		[Ordinal(25)] 
		[RED("startingAttributePoints")] 
		public CInt32 StartingAttributePoints
		{
			get => GetProperty(ref _startingAttributePoints);
			set => SetProperty(ref _startingAttributePoints, value);
		}

		[Ordinal(26)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(27)] 
		[RED("toolTipOffset")] 
		public inkMargin ToolTipOffset
		{
			get => GetProperty(ref _toolTipOffset);
			set => SetProperty(ref _toolTipOffset, value);
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(29)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get => GetProperty(ref _confirmAnimationProxy);
			set => SetProperty(ref _confirmAnimationProxy, value);
		}

		[Ordinal(30)] 
		[RED("hoverdWidget")] 
		public wCHandle<inkWidget> HoverdWidget
		{
			get => GetProperty(ref _hoverdWidget);
			set => SetProperty(ref _hoverdWidget, value);
		}

		public CharacterCreationStatsMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
