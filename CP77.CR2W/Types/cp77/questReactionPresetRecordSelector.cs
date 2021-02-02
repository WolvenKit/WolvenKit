using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questReactionPresetRecordSelector : ISerializable
	{
		[Ordinal(0)]  [RED("isGanger")] public CBool IsGanger { get; set; }
		[Ordinal(1)]  [RED("isCivilian")] public CBool IsCivilian { get; set; }
		[Ordinal(2)]  [RED("isCorpo")] public CBool IsCorpo { get; set; }
		[Ordinal(3)]  [RED("isPolice")] public CBool IsPolice { get; set; }
		[Ordinal(4)]  [RED("isMechanical")] public CBool IsMechanical { get; set; }
		[Ordinal(5)]  [RED("isNoReaction")] public CBool IsNoReaction { get; set; }
		[Ordinal(6)]  [RED("setDefault")] public CBool SetDefault { get; set; }
		[Ordinal(7)]  [RED("gangerRecordID")] public TweakDBID GangerRecordID { get; set; }
		[Ordinal(8)]  [RED("civilianRecordID")] public TweakDBID CivilianRecordID { get; set; }
		[Ordinal(9)]  [RED("corpoRecordID")] public TweakDBID CorpoRecordID { get; set; }
		[Ordinal(10)]  [RED("policeRecordID")] public TweakDBID PoliceRecordID { get; set; }
		[Ordinal(11)]  [RED("mechanicalRecordID")] public TweakDBID MechanicalRecordID { get; set; }
		[Ordinal(12)]  [RED("noReactionRecordID")] public TweakDBID NoReactionRecordID { get; set; }

		public questReactionPresetRecordSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
