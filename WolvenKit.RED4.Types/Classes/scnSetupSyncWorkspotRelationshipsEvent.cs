using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSetupSyncWorkspotRelationshipsEvent : scnSceneEvent
	{
		private CStatic<scnSceneWorkspotInstanceId> _syncedWorkspotIds;

		[Ordinal(6)] 
		[RED("syncedWorkspotIds", 4)] 
		public CStatic<scnSceneWorkspotInstanceId> SyncedWorkspotIds
		{
			get => GetProperty(ref _syncedWorkspotIds);
			set => SetProperty(ref _syncedWorkspotIds, value);
		}
	}
}
