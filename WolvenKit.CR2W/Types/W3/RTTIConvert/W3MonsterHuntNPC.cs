using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterHuntNPC : CNewNPC
	{
		[RED("MONSTER_HUNT_TARGET_TAG")] 		public CName MONSTER_HUNT_TARGET_TAG { get; set;}

		[RED("bossBarOn")] 		public CBool BossBarOn { get; set;}

		[RED("musicOn")] 		public CBool MusicOn { get; set;}

		[RED("displayBossBar")] 		public CBool DisplayBossBar { get; set;}

		[RED("switchMusic")] 		public CBool SwitchMusic { get; set;}

		[RED("questFocusSoundOnSpawn")] 		public CBool QuestFocusSoundOnSpawn { get; set;}

		[RED("dontTagForAchievement")] 		public CBool DontTagForAchievement { get; set;}

		[RED("disableDismemberment")] 		public CBool DisableDismemberment { get; set;}

		[RED("combatMusicStartEvent")] 		public CString CombatMusicStartEvent { get; set;}

		[RED("combatMusicStopEvent")] 		public CString CombatMusicStopEvent { get; set;}

		[RED("associatedInvestigationAreasTag")] 		public CName AssociatedInvestigationAreasTag { get; set;}

		[RED("investigationAreasProcessed")] 		public CBool InvestigationAreasProcessed { get; set;}

		public W3MonsterHuntNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MonsterHuntNPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}