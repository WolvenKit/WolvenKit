using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EntityNoticedPlayerPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("isPlayerNoticed")] public CBool IsPlayerNoticed { get; set; }
		[Ordinal(1)]  [RED("valueToListen")] public CUInt32 ValueToListen { get; set; }

		public EntityNoticedPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
