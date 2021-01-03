using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TVControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(0)]  [RED("backupCustomChannels")] public CArray<STvChannel> BackupCustomChannels { get; set; }
		[Ordinal(1)]  [RED("broadcastGlitchVideoPath")] public redResourceReferenceScriptToken BroadcastGlitchVideoPath { get; set; }
		[Ordinal(2)]  [RED("defaultGlitchVideoPath")] public redResourceReferenceScriptToken DefaultGlitchVideoPath { get; set; }
		[Ordinal(3)]  [RED("globalTVInitialized")] public CBool GlobalTVInitialized { get; set; }
		[Ordinal(4)]  [RED("tvSetup")] public TVSetup TvSetup { get; set; }

		public TVControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
