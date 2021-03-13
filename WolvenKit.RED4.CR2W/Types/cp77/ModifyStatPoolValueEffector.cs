using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolValueEffector : gameEffector
	{
		[Ordinal(0)] [RED("statPoolUpdates")] public CArray<wCHandle<gamedataStatPoolUpdate_Record>> StatPoolUpdates { get; set; }
		[Ordinal(1)] [RED("usePercent")] public CBool UsePercent { get; set; }
		[Ordinal(2)] [RED("applicationTarget")] public CString ApplicationTarget { get; set; }

		public ModifyStatPoolValueEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
