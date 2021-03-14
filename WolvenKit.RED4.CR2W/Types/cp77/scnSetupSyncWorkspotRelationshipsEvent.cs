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
			get
			{
				if (_syncedWorkspotIds == null)
				{
					_syncedWorkspotIds = (CStatic<scnSceneWorkspotInstanceId>) CR2WTypeManager.Create("static:4,scnSceneWorkspotInstanceId", "syncedWorkspotIds", cr2w, this);
				}
				return _syncedWorkspotIds;
			}
			set
			{
				if (_syncedWorkspotIds == value)
				{
					return;
				}
				_syncedWorkspotIds = value;
				PropertySet(this);
			}
		}

		public scnSetupSyncWorkspotRelationshipsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
