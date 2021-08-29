using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiUIInteractionData : RedBaseClass
	{
		private CBool _interactionListActive;
		private CBool _terminalInteractionActive;

		[Ordinal(0)] 
		[RED("interactionListActive")] 
		public CBool InteractionListActive
		{
			get => GetProperty(ref _interactionListActive);
			set => SetProperty(ref _interactionListActive, value);
		}

		[Ordinal(1)] 
		[RED("terminalInteractionActive")] 
		public CBool TerminalInteractionActive
		{
			get => GetProperty(ref _terminalInteractionActive);
			set => SetProperty(ref _terminalInteractionActive, value);
		}
	}
}
