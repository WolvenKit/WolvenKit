using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetQuickHackEvent : redEvent
	{
		private CBool _wasQuickHacked;
		private CName _quickHackName;

		[Ordinal(0)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get
			{
				if (_wasQuickHacked == null)
				{
					_wasQuickHacked = (CBool) CR2WTypeManager.Create("Bool", "wasQuickHacked", cr2w, this);
				}
				return _wasQuickHacked;
			}
			set
			{
				if (_wasQuickHacked == value)
				{
					return;
				}
				_wasQuickHacked = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("quickHackName")] 
		public CName QuickHackName
		{
			get
			{
				if (_quickHackName == null)
				{
					_quickHackName = (CName) CR2WTypeManager.Create("CName", "quickHackName", cr2w, this);
				}
				return _quickHackName;
			}
			set
			{
				if (_quickHackName == value)
				{
					return;
				}
				_quickHackName = value;
				PropertySet(this);
			}
		}

		public SetQuickHackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
