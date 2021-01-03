using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questAudioMusicSyncNodeType : questIAudioNodeType
	{
		[Ordinal(0)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(1)]  [RED("syncTrack")] public CName SyncTrack { get; set; }
		[Ordinal(2)]  [RED("syncType")] public CEnum<audioMusicSyncType> SyncType { get; set; }
		[Ordinal(3)]  [RED("userCue")] public CName UserCue { get; set; }

		public questAudioMusicSyncNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
