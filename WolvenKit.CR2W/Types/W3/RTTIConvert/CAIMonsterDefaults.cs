using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterDefaults : CAIBaseMonsterDefaults
	{
		[RED("combatTree")] 		public CHandle<CAIMonsterCombat> CombatTree { get; set;}

		[RED("deathTree")] 		public CHandle<CAIMonsterDeath> DeathTree { get; set;}

		[RED("spawnEntityAtDeath")] 		public CBool SpawnEntityAtDeath { get; set;}

		[RED("morphInCombat")] 		public CBool MorphInCombat { get; set;}

		[RED("entityToSpawn")] 		public CName EntityToSpawn { get; set;}

		public CAIMonsterDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}