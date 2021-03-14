using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerWeaponBasic : ScannerChunk
	{
		private CName _weapon;

		[Ordinal(0)] 
		[RED("weapon")] 
		public CName Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (CName) CR2WTypeManager.Create("CName", "weapon", cr2w, this);
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

		public ScannerWeaponBasic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
