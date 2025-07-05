using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoopAnimationLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("defaultAnimation")] 
		public CName DefaultAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("selectionRule")] 
		public CEnum<inkSelectionRule> SelectionRule
		{
			get => GetPropertyValue<CEnum<inkSelectionRule>>();
			set => SetPropertyValue<CEnum<inkSelectionRule>>(value);
		}

		public LoopAnimationLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
