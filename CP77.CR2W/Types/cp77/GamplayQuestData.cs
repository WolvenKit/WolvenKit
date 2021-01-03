using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GamplayQuestData : IScriptable
	{
		[Ordinal(0)]  [RED("objectives")] public CArray<CHandle<GemplayObjectiveData>> Objectives { get; set; }
		[Ordinal(1)]  [RED("questUniqueID")] public CString QuestUniqueID { get; set; }

		public GamplayQuestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
