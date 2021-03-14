using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRoleCondition : AIbehaviorconditionScript
	{
		private CEnum<EAIRole> _role;

		[Ordinal(0)] 
		[RED("role")] 
		public CEnum<EAIRole> Role
		{
			get
			{
				if (_role == null)
				{
					_role = (CEnum<EAIRole>) CR2WTypeManager.Create("EAIRole", "role", cr2w, this);
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

		public AIRoleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
