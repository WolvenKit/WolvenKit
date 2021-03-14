using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PatrolRoleCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CBool _patrolWithWeapon;
		private CBool _forceAlerted;

		[Ordinal(0)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get
			{
				if (_patrolWithWeapon == null)
				{
					_patrolWithWeapon = (CBool) CR2WTypeManager.Create("Bool", "patrolWithWeapon", cr2w, this);
				}
				return _patrolWithWeapon;
			}
			set
			{
				if (_patrolWithWeapon == value)
				{
					return;
				}
				_patrolWithWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceAlerted")] 
		public CBool ForceAlerted
		{
			get
			{
				if (_forceAlerted == null)
				{
					_forceAlerted = (CBool) CR2WTypeManager.Create("Bool", "forceAlerted", cr2w, this);
				}
				return _forceAlerted;
			}
			set
			{
				if (_forceAlerted == value)
				{
					return;
				}
				_forceAlerted = value;
				PropertySet(this);
			}
		}

		public PatrolRoleCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
