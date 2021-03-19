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
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}

		public ScannerWeaponDetailed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
