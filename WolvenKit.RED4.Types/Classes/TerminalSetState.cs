using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TerminalSetState : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get => GetPropertyValue<CEnum<gameinteractionsReactionState>>();
			set => SetPropertyValue<CEnum<gameinteractionsReactionState>>(value);
		}
	}
}
