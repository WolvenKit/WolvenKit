using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
