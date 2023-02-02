using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorNodeStatusDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)] 
		[RED("behaviorResourceHash")] 
		public CUInt32 BehaviorResourceHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("generation")] 
		public CUInt32 Generation
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<AIbehaviorNodeStatusDebuggerCommandEntry> Entries
		{
			get => GetPropertyValue<CArray<AIbehaviorNodeStatusDebuggerCommandEntry>>();
			set => SetPropertyValue<CArray<AIbehaviorNodeStatusDebuggerCommandEntry>>(value);
		}

		public AIbehaviorNodeStatusDebuggerCommand()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
