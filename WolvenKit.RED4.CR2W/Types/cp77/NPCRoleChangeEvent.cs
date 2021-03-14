using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCRoleChangeEvent : redEvent
	{
		private CHandle<AIRole> _newRole;

		[Ordinal(0)] 
		[RED("newRole")] 
		public CHandle<AIRole> NewRole
		{
			get
			{
				if (_newRole == null)
				{
					_newRole = (CHandle<AIRole>) CR2WTypeManager.Create("handle:AIRole", "newRole", cr2w, this);
				}
				return _newRole;
			}
			set
			{
				if (_newRole == value)
				{
					return;
				}
				_newRole = value;
				PropertySet(this);
			}
		}

		public NPCRoleChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
