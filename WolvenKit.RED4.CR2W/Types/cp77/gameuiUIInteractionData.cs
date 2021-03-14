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
			get
			{
				if (_interactionListActive == null)
				{
					_interactionListActive = (CBool) CR2WTypeManager.Create("Bool", "interactionListActive", cr2w, this);
				}
				return _interactionListActive;
			}
			set
			{
				if (_interactionListActive == value)
				{
					return;
				}
				_interactionListActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("terminalInteractionActive")] 
		public CBool TerminalInteractionActive
		{
			get
			{
				if (_terminalInteractionActive == null)
				{
					_terminalInteractionActive = (CBool) CR2WTypeManager.Create("Bool", "terminalInteractionActive", cr2w, this);
				}
				return _terminalInteractionActive;
			}
			set
			{
				if (_terminalInteractionActive == value)
				{
					return;
				}
				_terminalInteractionActive = value;
				PropertySet(this);
			}
		}

		public gameuiUIInteractionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
