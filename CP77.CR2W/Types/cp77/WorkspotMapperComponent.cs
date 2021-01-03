using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapperComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("workspotsMap")] public CArray<CHandle<WorkspotMapData>> WorkspotsMap { get; set; }

		public WorkspotMapperComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
