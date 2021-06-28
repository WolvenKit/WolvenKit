using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoopAnimationLogicController : inkWidgetLogicController
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

		public LoopAnimationLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
