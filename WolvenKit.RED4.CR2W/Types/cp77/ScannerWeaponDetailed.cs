using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerWeaponDetailed : ScannerWeaponBasic
	{
		[Ordinal(1)] [RED("damage")] public CName Damage { get; set; }

		public ScannerWeaponDetailed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
