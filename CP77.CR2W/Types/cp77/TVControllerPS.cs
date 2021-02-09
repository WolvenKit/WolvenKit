using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TVControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(108)]  [RED("tvSetup")] public TVSetup TvSetup { get; set; }
		[Ordinal(109)]  [RED("defaultGlitchVideoPath")] public redResourceReferenceScriptToken DefaultGlitchVideoPath { get; set; }
		[Ordinal(110)]  [RED("broadcastGlitchVideoPath")] public redResourceReferenceScriptToken BroadcastGlitchVideoPath { get; set; }
		[Ordinal(111)]  [RED("globalTVInitialized")] public CBool GlobalTVInitialized { get; set; }
		[Ordinal(112)]  [RED("backupCustomChannels")] public CArray<STvChannel> BackupCustomChannels { get; set; }

		public TVControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
