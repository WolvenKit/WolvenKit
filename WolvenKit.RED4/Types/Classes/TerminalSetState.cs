using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TerminalSetState : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get => GetPropertyValue<CEnum<gameinteractionsReactionState>>();
			set => SetPropertyValue<CEnum<gameinteractionsReactionState>>(value);
		}

		public TerminalSetState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
