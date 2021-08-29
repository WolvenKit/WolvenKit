using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorAgentInfoDebuggerCommandEntry : RedBaseClass
	{
		private AIbehaviorBehaviorInstanceCallStack _callStack;
		private CString _behaviorResourcePath;

		[Ordinal(0)] 
		[RED("callStack")] 
		public AIbehaviorBehaviorInstanceCallStack CallStack
		{
			get => GetProperty(ref _callStack);
			set => SetProperty(ref _callStack, value);
		}

		[Ordinal(1)] 
		[RED("behaviorResourcePath")] 
		public CString BehaviorResourcePath
		{
			get => GetProperty(ref _behaviorResourcePath);
			set => SetProperty(ref _behaviorResourcePath, value);
		}
	}
}
