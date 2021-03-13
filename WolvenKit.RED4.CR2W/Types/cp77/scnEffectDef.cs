using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectDef : CVariable
	{
		[Ordinal(0)] [RED("id")] public scnEffectId Id { get; set; }
		[Ordinal(1)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }

		public scnEffectDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
