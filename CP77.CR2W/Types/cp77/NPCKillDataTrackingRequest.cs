using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCKillDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("damageEntry")] public DamageHistoryEntry DamageEntry { get; set; }
		[Ordinal(1)]  [RED("eventType")] public CEnum<EDownedType> EventType { get; set; }
		[Ordinal(2)]  [RED("isDownedRecorded")] public CBool IsDownedRecorded { get; set; }

		public NPCKillDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
