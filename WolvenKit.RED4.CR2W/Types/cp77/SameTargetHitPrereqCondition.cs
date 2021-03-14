using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SameTargetHitPrereqCondition : BaseHitPrereqCondition
	{
		private wCHandle<gameObject> _previousTarget;
		private wCHandle<gameObject> _previousSource;
		private wCHandle<gameweaponObject> _previousWeapon;

		[Ordinal(1)] 
		[RED("previousTarget")] 
		public wCHandle<gameObject> PreviousTarget
		{
			get
			{
				if (_previousTarget == null)
				{
					_previousTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "previousTarget", cr2w, this);
				}
				return _previousTarget;
			}
			set
			{
				if (_previousTarget == value)
				{
					return;
				}
				_previousTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("previousSource")] 
		public wCHandle<gameObject> PreviousSource
		{
			get
			{
				if (_previousSource == null)
				{
					_previousSource = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "previousSource", cr2w, this);
				}
				return _previousSource;
			}
			set
			{
				if (_previousSource == value)
				{
					return;
				}
				_previousSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("previousWeapon")] 
		public wCHandle<gameweaponObject> PreviousWeapon
		{
			get
			{
				if (_previousWeapon == null)
				{
					_previousWeapon = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "previousWeapon", cr2w, this);
				}
				return _previousWeapon;
			}
			set
			{
				if (_previousWeapon == value)
				{
					return;
				}
				_previousWeapon = value;
				PropertySet(this);
			}
		}

		public SameTargetHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
