using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorBehaviorIncludedDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		private CArray<AIbehaviorBehaviorIncludedDebuggerCommandEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<AIbehaviorBehaviorIncludedDebuggerCommandEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
