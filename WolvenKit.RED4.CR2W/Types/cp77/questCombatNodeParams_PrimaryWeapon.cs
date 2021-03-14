using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_PrimaryWeapon : questCombatNodeParams
	{
		private CBool _unEquip;

		[Ordinal(0)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get
			{
				if (_unEquip == null)
				{
					_unEquip = (CBool) CR2WTypeManager.Create("Bool", "unEquip", cr2w, this);
				}
				return _unEquip;
			}
			set
			{
				if (_unEquip == value)
				{
					return;
				}
				_unEquip = value;
				PropertySet(this);
			}
		}

		public questCombatNodeParams_PrimaryWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
