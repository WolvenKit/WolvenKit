using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorkspotMapperComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("workspotsMap")] 
		public CArray<CHandle<WorkspotMapData>> WorkspotsMap
		{
			get => GetPropertyValue<CArray<CHandle<WorkspotMapData>>>();
			set => SetPropertyValue<CArray<CHandle<WorkspotMapData>>>(value);
		}

		public WorkspotMapperComponent()
		{
			WorkspotsMap = new();
		}
	}
}
