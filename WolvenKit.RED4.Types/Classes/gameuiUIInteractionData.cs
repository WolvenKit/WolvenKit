using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiUIInteractionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("interactionListActive")] 
		public CBool InteractionListActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("terminalInteractionActive")] 
		public CBool TerminalInteractionActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiUIInteractionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
