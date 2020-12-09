using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterHuntNPC : CNewNPC
	{
		[Ordinal(1)] [RED("MONSTER_HUNT_TARGET_TAG")] 		public CName MONSTER_HUNT_TARGET_TAG { get; set;}

		[Ordinal(2)] [RED("bossBarOn")] 		public CBool BossBarOn { get; set;}

		[Ordinal(3)] [RED("musicOn")] 		public CBool MusicOn { get; set;}

		[Ordinal(4)] [RED("displayBossBar")] 		public CBool DisplayBossBar { get; set;}

		[Ordinal(5)] [RED("switchMusic")] 		public CBool SwitchMusic { get; set;}

		[Ordinal(6)] [RED("questFocusSoundOnSpawn")] 		public CBool QuestFocusSoundOnSpawn { get; set;}

		[Ordinal(7)] [RED("dontTagForAchievement")] 		public CBool DontTagForAchievement { get; set;}

		[Ordinal(8)] [RED("disableDismemberment")] 		public CBool DisableDismemberment { get; set;}

		[Ordinal(9)] [RED("combatMusicStartEvent")] 		public CString CombatMusicStartEvent { get; set;}

		[Ordinal(10)] [RED("combatMusicStopEvent")] 		public CString CombatMusicStopEvent { get; set;}

		[Ordinal(11)] [RED("associatedInvestigationAreasTag")] 		public CName AssociatedInvestigationAreasTag { get; set;}

		[Ordinal(12)] [RED("investigationAreasProcessed")] 		public CBool InvestigationAreasProcessed { get; set;}

		public W3MonsterHuntNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MonsterHuntNPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}