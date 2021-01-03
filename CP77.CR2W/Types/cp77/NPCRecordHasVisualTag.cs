using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCRecordHasVisualTag : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("hasTag")] public CBool HasTag { get; set; }
		[Ordinal(1)]  [RED("visualTag")] public CName VisualTag { get; set; }

		public NPCRecordHasVisualTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
