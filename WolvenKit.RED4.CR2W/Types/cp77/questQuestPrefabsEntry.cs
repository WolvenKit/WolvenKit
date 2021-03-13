using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestPrefabsEntry : CVariable
	{
		[Ordinal(0)] [RED("nodeRef")] public worldGlobalNodeRef NodeRef { get; set; }
		[Ordinal(1)] [RED("loadingMode")] public CEnum<worldQuestPrefabLoadingMode> LoadingMode { get; set; }

		public questQuestPrefabsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
