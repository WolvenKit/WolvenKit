using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFSMStateDefinition : CVariable
	{
		private AIFSMTransitionListDefinition _onUpdateTransition;
		private AIFSMTransitionListDefinition _onCompleteTransition;
		private AIFSMTransitionListDefinition _onSuccessTransition;
		private AIFSMTransitionListDefinition _onFailureTransition;
		private AIFSMTransitionListDefinition _onInterruptionTransition;
		private AIFSMTransitionListDefinition _onEventTransitions;
		private CHandle<AICTreeNodeDefinition> _childNode;

		[Ordinal(0)] 
		[RED("onUpdateTransition")] 
		public AIFSMTransitionListDefinition OnUpdateTransition
		{
			get
			{
				if (_onUpdateTransition == null)
				{
					_onUpdateTransition = (AIFSMTransitionListDefinition) CR2WTypeManager.Create("AIFSMTransitionListDefinition", "onUpdateTransition", cr2w, this);
				}
				return _onUpdateTransition;
			}
			set
			{
				if (_onUpdateTransition == value)
				{
					return;
				}
				_onUpdateTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onCompleteTransition")] 
		public AIFSMTransitionListDefinition OnCompleteTransition
		{
			get
			{
				if (_onCompleteTransition == null)
				{
					_onCompleteTransition = (AIFSMTransitionListDefinition) CR2WTypeManager.Create("AIFSMTransitionListDefinition", "onCompleteTransition", cr2w, this);
				}
				return _onCompleteTransition;
			}
			set
			{
				if (_onCompleteTransition == value)
				{
					return;
				}
				_onCompleteTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onSuccessTransition")] 
		public AIFSMTransitionListDefinition OnSuccessTransition
		{
			get
			{
				if (_onSuccessTransition == null)
				{
					_onSuccessTransition = (AIFSMTransitionListDefinition) CR2WTypeManager.Create("AIFSMTransitionListDefinition", "onSuccessTransition", cr2w, this);
				}
				return _onSuccessTransition;
			}
			set
			{
				if (_onSuccessTransition == value)
				{
					return;
				}
				_onSuccessTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("onFailureTransition")] 
		public AIFSMTransitionListDefinition OnFailureTransition
		{
			get
			{
				if (_onFailureTransition == null)
				{
					_onFailureTransition = (AIFSMTransitionListDefinition) CR2WTypeManager.Create("AIFSMTransitionListDefinition", "onFailureTransition", cr2w, this);
				}
				return _onFailureTransition;
			}
			set
			{
				if (_onFailureTransition == value)
				{
					return;
				}
				_onFailureTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("onInterruptionTransition")] 
		public AIFSMTransitionListDefinition OnInterruptionTransition
		{
			get
			{
				if (_onInterruptionTransition == null)
				{
					_onInterruptionTransition = (AIFSMTransitionListDefinition) CR2WTypeManager.Create("AIFSMTransitionListDefinition", "onInterruptionTransition", cr2w, this);
				}
				return _onInterruptionTransition;
			}
			set
			{
				if (_onInterruptionTransition == value)
				{
					return;
				}
				_onInterruptionTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("onEventTransitions")] 
		public AIFSMTransitionListDefinition OnEventTransitions
		{
			get
			{
				if (_onEventTransitions == null)
				{
					_onEventTransitions = (AIFSMTransitionListDefinition) CR2WTypeManager.Create("AIFSMTransitionListDefinition", "onEventTransitions", cr2w, this);
				}
				return _onEventTransitions;
			}
			set
			{
				if (_onEventTransitions == value)
				{
					return;
				}
				_onEventTransitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("childNode")] 
		public CHandle<AICTreeNodeDefinition> ChildNode
		{
			get
			{
				if (_childNode == null)
				{
					_childNode = (CHandle<AICTreeNodeDefinition>) CR2WTypeManager.Create("handle:AICTreeNodeDefinition", "childNode", cr2w, this);
				}
				return _childNode;
			}
			set
			{
				if (_childNode == value)
				{
					return;
				}
				_childNode = value;
				PropertySet(this);
			}
		}

		public AIFSMStateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
