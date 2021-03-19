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
			get => GetProperty(ref _behaviorRoot);
			set => SetProperty(ref _behaviorRoot, value);
		}

		[Ordinal(1)] 
		[RED("isInitial")] 
		public CBool IsInitial
		{
			get => GetProperty(ref _isInitial);
			set => SetProperty(ref _isInitial, value);
		}

		[Ordinal(2)] 
		[RED("isExit")] 
		public CBool IsExit
		{
			get => GetProperty(ref _isExit);
			set => SetProperty(ref _isExit, value);
		}

		[Ordinal(3)] 
		[RED("completionStatus")] 
		public CEnum<AIbehaviorStateCompletionStatus> CompletionStatus
		{
			get => GetProperty(ref _completionStatus);
			set => SetProperty(ref _completionStatus, value);
		}

		public AIbehaviorFSMStateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
