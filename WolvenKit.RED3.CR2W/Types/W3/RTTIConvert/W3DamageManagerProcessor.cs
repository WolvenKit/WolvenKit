using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DamageManagerProcessor : CObject
	{
		[Ordinal(1)] [RED("playerAttacker")] 		public CHandle<CR4Player> PlayerAttacker { get; set;}

		[Ordinal(2)] [RED("playerVictim")] 		public CHandle<CR4Player> PlayerVictim { get; set;}

		[Ordinal(3)] [RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(4)] [RED("attackAction")] 		public CHandle<W3Action_Attack> AttackAction { get; set;}

		[Ordinal(5)] [RED("weaponId")] 		public SItemUniqueId WeaponId { get; set;}

		[Ordinal(6)] [RED("actorVictim")] 		public CHandle<CActor> ActorVictim { get; set;}

		[Ordinal(7)] [RED("actorAttacker")] 		public CHandle<CActor> ActorAttacker { get; set;}

		[Ordinal(8)] [RED("dm")] 		public CHandle<CDefinitionsManagerAccessor> Dm { get; set;}

		[Ordinal(9)] [RED("attackerMonsterCategory")] 		public CEnum<EMonsterCategory> AttackerMonsterCategory { get; set;}

		[Ordinal(10)] [RED("victimMonsterCategory")] 		public CEnum<EMonsterCategory> VictimMonsterCategory { get; set;}

		[Ordinal(11)] [RED("victimCanBeHitByFists")] 		public CBool VictimCanBeHitByFists { get; set;}

		public W3DamageManagerProcessor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageManagerProcessor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}