using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ClueStash : W3MonsterClue
	{
		[Ordinal(1)] [RED("lootEntityTemplate")] 		public CHandle<CEntityTemplate> LootEntityTemplate { get; set;}

		[Ordinal(2)] [RED("setInvisibleAppearanceAfterLootingStash")] 		public CBool SetInvisibleAppearanceAfterLootingStash { get; set;}

		[Ordinal(3)] [RED("showLootPanelImmediately")] 		public CBool ShowLootPanelImmediately { get; set;}

		[Ordinal(4)] [RED("isStashDisabled")] 		public CBool IsStashDisabled { get; set;}

		[Ordinal(5)] [RED("stashOpenDelay")] 		public CFloat StashOpenDelay { get; set;}

		[Ordinal(6)] [RED("stashSpawnOffset")] 		public Vector StashSpawnOffset { get; set;}

		[Ordinal(7)] [RED("lootEntityTag")] 		public CName LootEntityTag { get; set;}

		[Ordinal(8)] [RED("currentAppearance")] 		public CName CurrentAppearance { get; set;}

		[Ordinal(9)] [RED("lootEntity")] 		public CHandle<W3Container> LootEntity { get; set;}

		[Ordinal(10)] [RED("lootWasOfferedToPlayer")] 		public CBool LootWasOfferedToPlayer { get; set;}

		[Ordinal(11)] [RED("stashWasLooted")] 		public CBool StashWasLooted { get; set;}

		public W3ClueStash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ClueStash(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}