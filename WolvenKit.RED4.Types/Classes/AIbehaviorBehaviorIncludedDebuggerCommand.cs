using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorBehaviorIncludedDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<AIbehaviorBehaviorIncludedDebuggerCommandEntry> Entries
		{
			get => GetPropertyValue<CArray<AIbehaviorBehaviorIncludedDebuggerCommandEntry>>();
			set => SetPropertyValue<CArray<AIbehaviorBehaviorIncludedDebuggerCommandEntry>>(value);
		}

		public AIbehaviorBehaviorIncludedDebuggerCommand()
		{
			Entries = new();
		}
	}
}
