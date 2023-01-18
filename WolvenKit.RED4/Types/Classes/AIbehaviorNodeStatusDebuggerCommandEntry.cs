using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorNodeStatusDebuggerCommandEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public CGuid NodeId
		{
			get => GetPropertyValue<CGuid>();
			set => SetPropertyValue<CGuid>(value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<AIbehaviorDebugNodeStatus> Status
		{
			get => GetPropertyValue<CEnum<AIbehaviorDebugNodeStatus>>();
			set => SetPropertyValue<CEnum<AIbehaviorDebugNodeStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("generation")] 
		public CUInt32 Generation
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("failure")] 
		public CHandle<gamedebugFailure> Failure
		{
			get => GetPropertyValue<CHandle<gamedebugFailure>>();
			set => SetPropertyValue<CHandle<gamedebugFailure>>(value);
		}

		public AIbehaviorNodeStatusDebuggerCommandEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
