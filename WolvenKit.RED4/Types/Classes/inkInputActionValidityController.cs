using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkInputActionValidityController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("invertVisibility")] 
		public CBool InvertVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("inputValidityDependentWidgets")] 
		public CArray<inkWidgetReference> InputValidityDependentWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public inkInputActionValidityController()
		{
			InputValidityDependentWidgets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
