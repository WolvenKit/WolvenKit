using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachineSFX : VendingMachineSFX
	{
		[Ordinal(2)] [RED("processing")] public CName Processing { get; set; }
		[Ordinal(3)] [RED("gunFalls")] public CName GunFalls { get; set; }

		public WeaponVendingMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
