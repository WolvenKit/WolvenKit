using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSetupSyncWorkspotRelationshipsEvent : scnSceneEvent
	{
		private CStatic<scnSceneWorkspotInstanceId> _syncedWorkspotIds;

		[Ordinal(6)] 
		[RED("syncedWorkspotIds", 4)] 
		public CStatic<scnSceneWorkspotInstanceId> SyncedWorkspotIds
		{
			get => GetProperty(ref _syncedWorkspotIds);
			set => SetProperty(ref _syncedWorkspotIds, value);
		}

		public scnSetupSyncWorkspotRelationshipsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
