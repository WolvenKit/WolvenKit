using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PublicSafeEvents : WeaponEventsTransition
	{
		private CBool _weaponUnequipRequestSent;

		[Ordinal(0)] 
		[RED("weaponUnequipRequestSent")] 
		public CBool WeaponUnequipRequestSent
		{
			get
			{
				if (_weaponUnequipRequestSent == null)
				{
					_weaponUnequipRequestSent = (CBool) CR2WTypeManager.Create("Bool", "weaponUnequipRequestSent", cr2w, this);
				}
				return _weaponUnequipRequestSent;
			}
			set
			{
				if (_weaponUnequipRequestSent == value)
				{
					return;
				}
				_weaponUnequipRequestSent = value;
				PropertySet(this);
			}
		}

		public PublicSafeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
