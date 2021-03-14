using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHackingManager_SetHacked : questHackingManager_ActionType
	{
		private CBool _hacked;

		[Ordinal(0)] 
		[RED("hacked")] 
		public CBool Hacked
		{
			get
			{
				if (_hacked == null)
				{
					_hacked = (CBool) CR2WTypeManager.Create("Bool", "hacked", cr2w, this);
				}
				return _hacked;
			}
			set
			{
				if (_hacked == value)
				{
					return;
				}
				_hacked = value;
				PropertySet(this);
			}
		}

		public questHackingManager_SetHacked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
