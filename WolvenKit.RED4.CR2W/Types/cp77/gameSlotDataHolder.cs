using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSlotDataHolder : IScriptable
	{
		private CArray<gameAmmoData> _ammoData;
		private gameSlotWeaponData _weapon;

		[Ordinal(0)] 
		[RED("ammoData")] 
		public CArray<gameAmmoData> AmmoData
		{
			get
			{
				if (_ammoData == null)
				{
					_ammoData = (CArray<gameAmmoData>) CR2WTypeManager.Create("array:gameAmmoData", "ammoData", cr2w, this);
				}
				return _ammoData;
			}
			set
			{
				if (_ammoData == value)
				{
					return;
				}
				_ammoData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public gameSlotWeaponData Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (gameSlotWeaponData) CR2WTypeManager.Create("gameSlotWeaponData", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		public gameSlotDataHolder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
