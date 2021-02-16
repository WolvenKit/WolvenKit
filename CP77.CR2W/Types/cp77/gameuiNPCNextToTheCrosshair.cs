using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiNPCNextToTheCrosshair : CVariable
	{
		[Ordinal(0)] [RED("npc")] public wCHandle<gameObject> Npc { get; set; }
		[Ordinal(1)] [RED("name")] public CString Name { get; set; }
		[Ordinal(2)] [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(3)] [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(4)] [RED("currentCyberwarePct")] public CInt32 CurrentCyberwarePct { get; set; }
		[Ordinal(5)] [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(6)] [RED("quickHackUpload")] public CInt32 QuickHackUpload { get; set; }
		[Ordinal(7)] [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }
		[Ordinal(8)] [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }
		[Ordinal(9)] [RED("isTagged")] public CBool IsTagged { get; set; }
		[Ordinal(10)] [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(11)] [RED("canSeePlayer")] public CBool CanSeePlayer { get; set; }
		[Ordinal(12)] [RED("playerDetectionAboveZero")] public CBool PlayerDetectionAboveZero { get; set; }
		[Ordinal(13)] [RED("playerDetectionAtMax")] public CBool PlayerDetectionAtMax { get; set; }

		public gameuiNPCNextToTheCrosshair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
