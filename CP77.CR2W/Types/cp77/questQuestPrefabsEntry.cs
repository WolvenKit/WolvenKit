using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questQuestPrefabsEntry : CVariable
	{
		[Ordinal(0)]  [RED("loadingMode")] public CEnum<worldQuestPrefabLoadingMode> LoadingMode { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public worldGlobalNodeRef NodeRef { get; set; }

		public questQuestPrefabsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
