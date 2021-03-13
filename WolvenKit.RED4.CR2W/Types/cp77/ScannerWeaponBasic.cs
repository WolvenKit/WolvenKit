using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerWeaponBasic : ScannerChunk
	{
		[Ordinal(0)] [RED("weapon")] public CName Weapon { get; set; }

		public ScannerWeaponBasic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
