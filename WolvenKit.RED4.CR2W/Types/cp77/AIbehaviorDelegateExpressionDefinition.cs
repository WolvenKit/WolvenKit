using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDelegateExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private AIbehaviorDelegateAttrRef _delegateAttribute;
		private CArray<CName> _behaviorCallbackNames;

		[Ordinal(0)] 
		[RED("delegateAttribute")] 
		public AIbehaviorDelegateAttrRef DelegateAttribute
		{
			get => GetProperty(ref _delegateAttribute);
			set => SetProperty(ref _delegateAttribute, value);
		}

		[Ordinal(1)] 
		[RED("behaviorCallbackNames")] 
		public CArray<CName> BehaviorCallbackNames
		{
			get => GetProperty(ref _behaviorCallbackNames);
			set => SetProperty(ref _behaviorCallbackNames, value);
		}

		public AIbehaviorDelegateExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
