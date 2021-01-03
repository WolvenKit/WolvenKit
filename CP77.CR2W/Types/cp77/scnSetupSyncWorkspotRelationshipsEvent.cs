using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSetupSyncWorkspotRelationshipsEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("syncedWorkspotIds")] public CStatic<4,scnSceneWorkspotInstanceId> SyncedWorkspotIds { get; set; }

		public scnSetupSyncWorkspotRelationshipsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
