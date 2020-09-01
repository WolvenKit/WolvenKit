using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterDefaults : CAIBaseMonsterDefaults
	{
		[Ordinal(0)] [RED("combatTree")] 		public CHandle<CAIMonsterCombat> CombatTree { get; set;}

		[Ordinal(0)] [RED("deathTree")] 		public CHandle<CAIMonsterDeath> DeathTree { get; set;}

		[Ordinal(0)] [RED("spawnEntityAtDeath")] 		public CBool SpawnEntityAtDeath { get; set;}

		[Ordinal(0)] [RED("morphInCombat")] 		public CBool MorphInCombat { get; set;}

		[Ordinal(0)] [RED("entityToSpawn")] 		public CName EntityToSpawn { get; set;}

		public CAIMonsterDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}