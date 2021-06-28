using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUIInteractionData : CVariable
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

		public gameuiUIInteractionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
