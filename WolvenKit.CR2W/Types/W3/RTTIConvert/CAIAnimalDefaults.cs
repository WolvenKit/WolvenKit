using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalDefaults : CAIDefaults
	{
		[Ordinal(0)] [RED("combatTree")] 		public CHandle<CAIAnimalCombat> CombatTree { get; set;}

		[Ordinal(0)] [RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[Ordinal(0)] [RED("idleDecoratorTree")] 		public CHandle<CAIMonsterIdleDecorator> IdleDecoratorTree { get; set;}

		[Ordinal(0)] [RED("charmedTree")] 		public CHandle<CAIAnimalCharmed> CharmedTree { get; set;}

		[Ordinal(0)] [RED("deathTree")] 		public CHandle<CAIAnimalDeath> DeathTree { get; set;}

		[Ordinal(0)] [RED("isAnimal")] 		public CBool IsAnimal { get; set;}

		public CAIAnimalDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAnimalDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}