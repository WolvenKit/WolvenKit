using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapperComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("workspotsMap")] public CArray<CHandle<WorkspotMapData>> WorkspotsMap { get; set; }

		public WorkspotMapperComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
