using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GamplayQuestData : IScriptable
	{
		[Ordinal(0)]  [RED("questUniqueID")] public CString QuestUniqueID { get; set; }
		[Ordinal(1)]  [RED("objectives")] public CArray<CHandle<GemplayObjectiveData>> Objectives { get; set; }

		public GamplayQuestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
