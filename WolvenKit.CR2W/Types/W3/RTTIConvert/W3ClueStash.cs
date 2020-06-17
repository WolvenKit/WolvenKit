using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ClueStash : W3MonsterClue
	{
		[RED("lootEntityTemplate")] 		public CHandle<CEntityTemplate> LootEntityTemplate { get; set;}

		[RED("setInvisibleAppearanceAfterLootingStash")] 		public CBool SetInvisibleAppearanceAfterLootingStash { get; set;}

		[RED("showLootPanelImmediately")] 		public CBool ShowLootPanelImmediately { get; set;}

		[RED("isStashDisabled")] 		public CBool IsStashDisabled { get; set;}

		[RED("stashOpenDelay")] 		public CFloat StashOpenDelay { get; set;}

		[RED("stashSpawnOffset")] 		public Vector StashSpawnOffset { get; set;}

		[RED("lootEntityTag")] 		public CName LootEntityTag { get; set;}

		public W3ClueStash(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ClueStash(cr2w);

	}
}