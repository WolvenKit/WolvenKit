using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDamageSystemSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)]  [RED("hitHistory")] public CArray<CHandle<gamedamageServerHitData>> HitHistory { get; set; }
		[Ordinal(1)]  [RED("killHistory")] public CArray<CHandle<gamedamageServerKillData>> KillHistory { get; set; }

		public gameDamageSystemSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
