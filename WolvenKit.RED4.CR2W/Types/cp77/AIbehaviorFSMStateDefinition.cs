using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFSMStateDefinition : AIbehaviorTreeNodeDefinition
	{
		private CHandle<AIbehaviorTreeNodeDefinition> _behaviorRoot;
		private CBool _isInitial;
		private CBool _isExit;
		private CEnum<AIbehaviorStateCompletionStatus> _completionStatus;

		[Ordinal(0)] 
		[RED("behaviorRoot")] 
		public CHandle<AIbehaviorTreeNodeDefinition> BehaviorRoot
		{
			get
			{
				if (_behaviorRoot == null)
				{
					_behaviorRoot = (CHandle<AIbehaviorTreeNodeDefinition>) CR2WTypeManager.Create("handle:AIbehaviorTreeNodeDefinition", "behaviorRoot", cr2w, this);
				}
				return _behaviorRoot;
			}
			set
			{
				if (_behaviorRoot == value)
				{
					return;
				}
				_behaviorRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInitial")] 
		public CBool IsInitial
		{
			get
			{
				if (_isInitial == null)
				{
					_isInitial = (CBool) CR2WTypeManager.Create("Bool", "isInitial", cr2w, this);
				}
				return _isInitial;
			}
			set
			{
				if (_isInitial == value)
				{
					return;
				}
				_isInitial = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isExit")] 
		public CBool IsExit
		{
			get
			{
				if (_isExit == null)
				{
					_isExit = (CBool) CR2WTypeManager.Create("Bool", "isExit", cr2w, this);
				}
				return _isExit;
			}
			set
			{
				if (_isExit == value)
				{
					return;
				}
				_isExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("completionStatus")] 
		public CEnum<AIbehaviorStateCompletionStatus> CompletionStatus
		{
			get
			{
				if (_completionStatus == null)
				{
					_completionStatus = (CEnum<AIbehaviorStateCompletionStatus>) CR2WTypeManager.Create("AIbehaviorStateCompletionStatus", "completionStatus", cr2w, this);
				}
				return _completionStatus;
			}
			set
			{
				if (_completionStatus == value)
				{
					return;
				}
				_completionStatus = value;
				PropertySet(this);
			}
		}

		public AIbehaviorFSMStateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
