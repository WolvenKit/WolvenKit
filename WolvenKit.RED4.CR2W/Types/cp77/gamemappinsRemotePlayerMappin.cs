using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsRemotePlayerMappin : gamemappinsRuntimeMappin
	{
		[Ordinal(0)] [RED("hasMissionData")] public CBool HasMissionData { get; set; }
		[Ordinal(1)] [RED("vitals")] public CInt32 Vitals { get; set; }

		public gamemappinsRemotePlayerMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
