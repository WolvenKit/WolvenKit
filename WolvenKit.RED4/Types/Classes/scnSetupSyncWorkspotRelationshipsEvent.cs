using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSetupSyncWorkspotRelationshipsEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("syncedWorkspotIds", 4)] 
		public CStatic<scnSceneWorkspotInstanceId> SyncedWorkspotIds
		{
			get => GetPropertyValue<CStatic<scnSceneWorkspotInstanceId>>();
			set => SetPropertyValue<CStatic<scnSceneWorkspotInstanceId>>(value);
		}

		public scnSetupSyncWorkspotRelationshipsEvent()
		{
			Id = new scnSceneEventId();
			SyncedWorkspotIds = new(4);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
