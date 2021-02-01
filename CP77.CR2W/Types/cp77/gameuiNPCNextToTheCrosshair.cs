using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiNPCNextToTheCrosshair : CVariable
	{
		[Ordinal(0)]  [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }
		[Ordinal(1)]  [RED("canSeePlayer")] public CBool CanSeePlayer { get; set; }
		[Ordinal(2)]  [RED("currentCyberwarePct")] public CInt32 CurrentCyberwarePct { get; set; }
		[Ordinal(3)]  [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(4)]  [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(5)]  [RED("isTagged")] public CBool IsTagged { get; set; }
		[Ordinal(6)]  [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(7)]  [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(8)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(9)]  [RED("npc")] public wCHandle<gameObject> Npc { get; set; }
		[Ordinal(10)]  [RED("playerDetectionAboveZero")] public CBool PlayerDetectionAboveZero { get; set; }
		[Ordinal(11)]  [RED("playerDetectionAtMax")] public CBool PlayerDetectionAtMax { get; set; }
		[Ordinal(12)]  [RED("quickHackUpload")] public CInt32 QuickHackUpload { get; set; }
		[Ordinal(13)]  [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }

		public gameuiNPCNextToTheCrosshair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
