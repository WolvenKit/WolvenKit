using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorkspotMapperComponent : gameScriptableComponent
	{
		private CArray<CHandle<WorkspotMapData>> _workspotsMap;

		[Ordinal(5)] 
		[RED("workspotsMap")] 
		public CArray<CHandle<WorkspotMapData>> WorkspotsMap
		{
			get => GetProperty(ref _workspotsMap);
			set => SetProperty(ref _workspotsMap, value);
		}
	}
}
