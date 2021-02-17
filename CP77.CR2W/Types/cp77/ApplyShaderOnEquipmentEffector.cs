using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderOnEquipmentEffector : gameEffector
	{
		[Ordinal(0)] [RED("items")] public CArray<wCHandle<gameItemObject>> Items { get; set; }
		[Ordinal(1)] [RED("effects")] public CArray<CHandle<gameEffectInstance>> Effects { get; set; }
		[Ordinal(2)] [RED("overrideMaterialName")] public CString OverrideMaterialName { get; set; }
		[Ordinal(3)] [RED("overrideMaterialTag")] public CName OverrideMaterialTag { get; set; }
		[Ordinal(4)] [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(5)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(6)] [RED("ownerEffect")] public CHandle<gameEffectInstance> OwnerEffect { get; set; }

		public ApplyShaderOnEquipmentEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
