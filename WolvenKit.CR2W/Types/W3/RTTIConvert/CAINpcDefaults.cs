using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcDefaults : CAIDefaults
	{
		[RED("npcGroupType")] 		public CHandle<CAINPCGroupTypeRedefinition> NpcGroupType { get; set;}

		[RED("combatTree")] 		public CHandle<CAINpcCombat> CombatTree { get; set;}

		[RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[RED("deathTree")] 		public CHandle<CAIDeathTree> DeathTree { get; set;}

		[RED("reactionTree")] 		public CHandle<CAINpcReactionsTree> ReactionTree { get; set;}

		[RED("softReactionTree")] 		public CHandle<CAISoftReactionTree> SoftReactionTree { get; set;}

		[RED("hasDrinkingMinigame")] 		public CBool HasDrinkingMinigame { get; set;}

		[RED("morphInCombat")] 		public CBool MorphInCombat { get; set;}

		public CAINpcDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}