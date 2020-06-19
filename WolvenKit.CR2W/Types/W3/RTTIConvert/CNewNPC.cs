using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CNewNPC : CActor
	{
		[RED("aiEnabled")] 		public CBool AiEnabled { get; set;}

		[RED("suppressBroadcastingReactions")] 		public CBool SuppressBroadcastingReactions { get; set;}

		[RED("berserkTime")] 		public EngineTime BerserkTime { get; set;}

		[RED("npcGroupType")] 		public CEnum<ENPCGroupType> NpcGroupType { get; set;}

		[RED("isImmortal")] 		public CBool IsImmortal { get; set;}

		[RED("isInvulnerable")] 		public CBool IsInvulnerable { get; set;}

		[RED("willBeUnconscious")] 		public CBool WillBeUnconscious { get; set;}

		[RED("minUnconsciousTime")] 		public CFloat MinUnconsciousTime { get; set;}

		[RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[RED("RemainsTags", 2,0)] 		public CArray<CName> RemainsTags { get; set;}

		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("levelFakeAddon")] 		public CInt32 LevelFakeAddon { get; set;}

		[RED("isMiniBossLevel")] 		public CBool IsMiniBossLevel { get; set;}

		[RED("dontUseReactionOneLiners")] 		public CBool DontUseReactionOneLiners { get; set;}

		[RED("disableConstrainLookat")] 		public CBool DisableConstrainLookat { get; set;}

		[RED("isMonsterType_Group")] 		public CBool IsMonsterType_Group { get; set;}

		[RED("useSoundValue")] 		public CBool UseSoundValue { get; set;}

		[RED("soundValue")] 		public CInt32 SoundValue { get; set;}

		[RED("clearInvOnDeath")] 		public CBool ClearInvOnDeath { get; set;}

		[RED("noAdaptiveBalance")] 		public CBool NoAdaptiveBalance { get; set;}

		[RED("grantNoExperienceAfterKill")] 		public CBool GrantNoExperienceAfterKill { get; set;}

		[RED("abilityBuffStackedOnEnemyHitName")] 		public CName AbilityBuffStackedOnEnemyHitName { get; set;}

		public CNewNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNewNPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}