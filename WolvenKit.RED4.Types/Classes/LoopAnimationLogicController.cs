using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LoopAnimationLogicController : inkWidgetLogicController
	{
		private CName _defaultAnimation;
		private CEnum<inkSelectionRule> _selectionRule;

		[Ordinal(1)] 
		[RED("defaultAnimation")] 
		public CName DefaultAnimation
		{
			get => GetProperty(ref _defaultAnimation);
			set => SetProperty(ref _defaultAnimation, value);
		}

		[Ordinal(2)] 
		[RED("selectionRule")] 
		public CEnum<inkSelectionRule> SelectionRule
		{
			get => GetProperty(ref _selectionRule);
			set => SetProperty(ref _selectionRule, value);
		}
	}
}
