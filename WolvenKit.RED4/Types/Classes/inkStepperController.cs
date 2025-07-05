using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStepperController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("indicatorUnitLibraryID")] 
		public CName IndicatorUnitLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("currentValueDisplay")] 
		public inkTextWidgetReference CurrentValueDisplay
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("indicatorContainer")] 
		public inkCompoundWidgetReference IndicatorContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("leftButton")] 
		public inkWidgetReference LeftButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("rightButton")] 
		public inkWidgetReference RightButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("Change")] 
		public inkStepperChangedCallback Change
		{
			get => GetPropertyValue<inkStepperChangedCallback>();
			set => SetPropertyValue<inkStepperChangedCallback>(value);
		}

		public inkStepperController()
		{
			CycledNavigation = true;
			CurrentValueDisplay = new inkTextWidgetReference();
			IndicatorContainer = new inkCompoundWidgetReference();
			LeftButton = new inkWidgetReference();
			RightButton = new inkWidgetReference();
			Change = new inkStepperChangedCallback();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
