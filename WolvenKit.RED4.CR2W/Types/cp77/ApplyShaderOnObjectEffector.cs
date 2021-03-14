using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderOnObjectEffector : gameEffector
	{
		[Ordinal(0)] [RED("applicationTargetString")] public CString ApplicationTargetString { get; set; }
		[Ordinal(1)] [RED("applicationTarget")] public wCHandle<gameObject> ApplicationTarget { get; set; }
		[Ordinal(2)] [RED("effects")] public CArray<CHandle<gameEffectInstance>> Effects { get; set; }
		[Ordinal(3)] [RED("overrideMaterialName")] public CString OverrideMaterialName { get; set; }
		[Ordinal(4)] [RED("overrideMaterialTag")] public CName OverrideMaterialTag { get; set; }
		[Ordinal(5)] [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(6)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(7)] [RED("ownerEffect")] public CHandle<gameEffectInstance> OwnerEffect { get; set; }

		public ApplyShaderOnObjectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
