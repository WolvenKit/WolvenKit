using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorkspotMapData : IScriptable
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gamedataWorkspotActionType> Action
		{
			get => GetPropertyValue<CEnum<gamedataWorkspotActionType>>();
			set => SetPropertyValue<CEnum<gamedataWorkspotActionType>>(value);
		}

		[Ordinal(1)] 
		[RED("workspots")] 
		public CArray<CHandle<WorkspotEntryData>> Workspots
		{
			get => GetPropertyValue<CArray<CHandle<WorkspotEntryData>>>();
			set => SetPropertyValue<CArray<CHandle<WorkspotEntryData>>>(value);
		}

		public WorkspotMapData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
