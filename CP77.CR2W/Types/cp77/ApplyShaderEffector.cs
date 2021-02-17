using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderEffector : gameEffector
	{
		[Ordinal(0)] [RED("overrideMaterialName")] public CName OverrideMaterialName { get; set; }
		[Ordinal(1)] [RED("overrideMaterialTag")] public CName OverrideMaterialTag { get; set; }
		[Ordinal(2)] [RED("applyToOwner")] public CBool ApplyToOwner { get; set; }
		[Ordinal(3)] [RED("applyToWeapon")] public CBool ApplyToWeapon { get; set; }
		[Ordinal(4)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(5)] [RED("ownerWeapons")] public CArray<wCHandle<gameItemObject>> OwnerWeapons { get; set; }
		[Ordinal(6)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public ApplyShaderEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
