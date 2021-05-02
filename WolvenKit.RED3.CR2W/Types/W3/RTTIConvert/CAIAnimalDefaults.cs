using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalDefaults : CAIDefaults
	{
		[Ordinal(1)] [RED("combatTree")] 		public CHandle<CAIAnimalCombat> CombatTree { get; set;}

		[Ordinal(2)] [RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[Ordinal(3)] [RED("idleDecoratorTree")] 		public CHandle<CAIMonsterIdleDecorator> IdleDecoratorTree { get; set;}

		[Ordinal(4)] [RED("charmedTree")] 		public CHandle<CAIAnimalCharmed> CharmedTree { get; set;}

		[Ordinal(5)] [RED("deathTree")] 		public CHandle<CAIAnimalDeath> DeathTree { get; set;}

		[Ordinal(6)] [RED("isAnimal")] 		public CBool IsAnimal { get; set;}

		public CAIAnimalDefaults(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAnimalDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}