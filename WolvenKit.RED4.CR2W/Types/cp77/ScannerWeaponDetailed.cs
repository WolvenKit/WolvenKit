using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerWeaponDetailed : ScannerWeaponBasic
	{
		private CName _damage;

		[Ordinal(1)] 
		[RED("damage")] 
		public CName Damage
		{
			get
			{
				if (_damage == null)
				{
					_damage = (CName) CR2WTypeManager.Create("CName", "damage", cr2w, this);
				}
				return _damage;
			}
			set
			{
				if (_damage == value)
				{
					return;
				}
				_damage = value;
				PropertySet(this);
			}
		}

		public ScannerWeaponDetailed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
