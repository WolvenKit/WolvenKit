using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlyingMonsterDefaults : CAIBaseMonsterDefaults
	{
		[RED("combatTree")] 		public CHandle<CAIFlyingMonsterCombat> CombatTree { get; set;}

		[RED("deathTree")] 		public CHandle<CAIFlyingMonsterDeath> DeathTree { get; set;}

		[RED("flyingWander")] 		public CHandle<CAISubTree> FlyingWander { get; set;}

		[RED("freeFlight")] 		public CHandle<IAIFlightIdleTree> FreeFlight { get; set;}

		[RED("canFly")] 		public CBool CanFly { get; set;}

		public CAIFlyingMonsterDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlyingMonsterDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}