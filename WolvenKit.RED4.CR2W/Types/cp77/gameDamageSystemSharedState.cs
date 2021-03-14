using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDamageSystemSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] [RED("hitHistory")] public CArray<CHandle<gamedamageServerHitData>> HitHistory { get; set; }
		[Ordinal(1)] [RED("killHistory")] public CArray<CHandle<gamedamageServerKillData>> KillHistory { get; set; }

		public gameDamageSystemSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
