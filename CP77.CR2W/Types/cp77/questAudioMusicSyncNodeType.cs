using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAudioMusicSyncNodeType : questIAudioNodeType
	{
		[Ordinal(0)]  [RED("syncType")] public CEnum<audioMusicSyncType> SyncType { get; set; }
		[Ordinal(1)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(2)]  [RED("syncTrack")] public CName SyncTrack { get; set; }
		[Ordinal(3)]  [RED("userCue")] public CName UserCue { get; set; }

		public questAudioMusicSyncNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
