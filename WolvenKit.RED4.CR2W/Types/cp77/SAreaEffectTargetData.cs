using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SAreaEffectTargetData : CVariable
	{
		[Ordinal(0)] [RED("areaEffectID")] public CName AreaEffectID { get; set; }
		[Ordinal(1)] [RED("onSelf")] public CBool OnSelf { get; set; }
		[Ordinal(2)] [RED("onSlaves")] public CBool OnSlaves { get; set; }

		public SAreaEffectTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
