using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCRecordHasVisualTag : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("visualTag")] public CName VisualTag { get; set; }
		[Ordinal(1)] [RED("hasTag")] public CBool HasTag { get; set; }

		public NPCRecordHasVisualTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
