using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalDefaults : CAIDefaults
	{
		[RED("combatTree")] 		public CHandle<CAIAnimalCombat> CombatTree { get; set;}

		[RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[RED("idleDecoratorTree")] 		public CHandle<CAIMonsterIdleDecorator> IdleDecoratorTree { get; set;}

		[RED("charmedTree")] 		public CHandle<CAIAnimalCharmed> CharmedTree { get; set;}

		[RED("deathTree")] 		public CHandle<CAIAnimalDeath> DeathTree { get; set;}

		[RED("isAnimal")] 		public CBool IsAnimal { get; set;}

		public CAIAnimalDefaults(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIAnimalDefaults(cr2w);

	}
}