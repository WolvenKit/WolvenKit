using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlyingMonsterDefaults : CAIBaseMonsterDefaults
	{
		[Ordinal(1)] [RED("combatTree")] 		public CHandle<CAIFlyingMonsterCombat> CombatTree { get; set;}

		[Ordinal(2)] [RED("deathTree")] 		public CHandle<CAIFlyingMonsterDeath> DeathTree { get; set;}

		[Ordinal(3)] [RED("flyingWander")] 		public CHandle<CAISubTree> FlyingWander { get; set;}

		[Ordinal(4)] [RED("freeFlight")] 		public CHandle<IAIFlightIdleTree> FreeFlight { get; set;}

		[Ordinal(5)] [RED("canFly")] 		public CBool CanFly { get; set;}

		public CAIFlyingMonsterDefaults(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlyingMonsterDefaults(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}