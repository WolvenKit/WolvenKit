using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterDefaults : CAIBaseMonsterDefaults
	{
		[Ordinal(1)] [RED("combatTree")] 		public CHandle<CAIMonsterCombat> CombatTree { get; set;}

		[Ordinal(2)] [RED("deathTree")] 		public CHandle<CAIMonsterDeath> DeathTree { get; set;}

		[Ordinal(3)] [RED("spawnEntityAtDeath")] 		public CBool SpawnEntityAtDeath { get; set;}

		[Ordinal(4)] [RED("morphInCombat")] 		public CBool MorphInCombat { get; set;}

		[Ordinal(5)] [RED("entityToSpawn")] 		public CName EntityToSpawn { get; set;}

		public CAIMonsterDefaults(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}