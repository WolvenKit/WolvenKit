using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorAgentInfoDebuggerCommandEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("callStack")] 
		public AIbehaviorBehaviorInstanceCallStack CallStack
		{
			get => GetPropertyValue<AIbehaviorBehaviorInstanceCallStack>();
			set => SetPropertyValue<AIbehaviorBehaviorInstanceCallStack>(value);
		}

		[Ordinal(1)] 
		[RED("behaviorResourcePath")] 
		public CString BehaviorResourcePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public AIbehaviorAgentInfoDebuggerCommandEntry()
		{
			CallStack = new() { ResourceHashes = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
