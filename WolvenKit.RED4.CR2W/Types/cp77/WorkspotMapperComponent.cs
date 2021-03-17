using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapperComponent : gameScriptableComponent
	{
		private CArray<CHandle<WorkspotMapData>> _workspotsMap;

		[Ordinal(5)] 
		[RED("workspotsMap")] 
		public CArray<CHandle<WorkspotMapData>> WorkspotsMap
		{
			get => GetProperty(ref _workspotsMap);
			set => SetProperty(ref _workspotsMap, value);
		}

		public WorkspotMapperComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
