using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveRoleCondition : AIbehaviorexpressionScript
	{
		private CEnum<EAIRole> _role;
		private CUInt32 _roleCbId;

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

		[Ordinal(1)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get
			{
				if (_roleCbId == null)
				{
					_roleCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "roleCbId", cr2w, this);
				}
				return _roleCbId;
			}
			set
			{
				if (_roleCbId == value)
				{
					return;
				}
				_roleCbId = value;
				PropertySet(this);
			}
		}

		public PassiveRoleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
