using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrillerUIEvent : redEvent
	{
		private gameinteractionsChoice _actionChosen;
		private wCHandle<gameObject> _activator;

		[Ordinal(0)] 
		[RED("actionChosen")] 
		public gameinteractionsChoice ActionChosen
		{
			get
			{
				if (_actionChosen == null)
				{
					_actionChosen = (gameinteractionsChoice) CR2WTypeManager.Create("gameinteractionsChoice", "actionChosen", cr2w, this);
				}
				return _actionChosen;
			}
			set
			{
				if (_actionChosen == value)
				{
					return;
				}
				_actionChosen = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
		{
			get
			{
				if (_activator == null)
				{
					_activator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "activator", cr2w, this);
				}
				return _activator;
			}
			set
			{
				if (_activator == value)
				{
					return;
				}
				_activator = value;
				PropertySet(this);
			}
		}

		public DrillerUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
