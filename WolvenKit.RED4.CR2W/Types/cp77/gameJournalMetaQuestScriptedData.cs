using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalMetaQuestScriptedData : CVariable
	{
		[Ordinal(0)] [RED("percent")] public CUInt32 Percent { get; set; }
		[Ordinal(1)] [RED("hidden")] public CBool Hidden { get; set; }
		[Ordinal(2)] [RED("text")] public CString Text { get; set; }

		public gameJournalMetaQuestScriptedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
