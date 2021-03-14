using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiLogTutorialHintActionEvent : redEvent
	{
		private CName _actionName;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		public gameuiLogTutorialHintActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
