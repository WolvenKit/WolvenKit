using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAssignRoleCommandParams : questScriptedAICommandParams
	{
		private CHandle<AIRole> _role;

		[Ordinal(0)] 
		[RED("role")] 
		public CHandle<AIRole> Role
		{
			get
			{
				if (_role == null)
				{
					_role = (CHandle<AIRole>) CR2WTypeManager.Create("handle:AIRole", "role", cr2w, this);
				}
				return _role;
			}
			set
			{
				if (_role == value)
				{
					return;
				}
				_role = value;
				PropertySet(this);
			}
		}

		public AIAssignRoleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
