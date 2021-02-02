using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemappinsRemotePlayerMappin : gamemappinsRuntimeMappin
	{
		[Ordinal(0)]  [RED("vitals")] public CInt32 Vitals { get; set; }
		[Ordinal(1)]  [RED("hasMissionData")] public CBool HasMissionData { get; set; }

		public gamemappinsRemotePlayerMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
