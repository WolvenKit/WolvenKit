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
			get
			{
				if (_delegateAttribute == null)
				{
					_delegateAttribute = (AIbehaviorDelegateAttrRef) CR2WTypeManager.Create("AIbehaviorDelegateAttrRef", "delegateAttribute", cr2w, this);
				}
				return _delegateAttribute;
			}
			set
			{
				if (_delegateAttribute == value)
				{
					return;
				}
				_delegateAttribute = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("behaviorCallbackNames")] 
		public CArray<CName> BehaviorCallbackNames
		{
			get
			{
				if (_behaviorCallbackNames == null)
				{
					_behaviorCallbackNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "behaviorCallbackNames", cr2w, this);
				}
				return _behaviorCallbackNames;
			}
			set
			{
				if (_behaviorCallbackNames == value)
				{
					return;
				}
				_behaviorCallbackNames = value;
				PropertySet(this);
			}
		}

		public AIbehaviorDelegateExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
