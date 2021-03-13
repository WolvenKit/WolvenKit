using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityNoticedPlayerPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("isPlayerNoticed")] public CBool IsPlayerNoticed { get; set; }
		[Ordinal(1)] [RED("valueToListen")] public CUInt32 ValueToListen { get; set; }

		public EntityNoticedPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
