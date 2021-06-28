using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMonsterNestUpdateDefinition : CVariable
	{
		[Ordinal(1)] [RED("isRebuilding")] 		public CBool IsRebuilding { get; set;}

		[Ordinal(2)] [RED("defaultPhaseToActivate")] 		public CName DefaultPhaseToActivate { get; set;}

		[Ordinal(3)] [RED("bossPhaseToActivate")] 		public CName BossPhaseToActivate { get; set;}

		[Ordinal(4)] [RED("hasBoss")] 		public CBool HasBoss { get; set;}

		[Ordinal(5)] [RED("bossSpawnDelay")] 		public CFloat BossSpawnDelay { get; set;}

		[Ordinal(6)] [RED("nestRebuildSchedule")] 		public GameTimeWrapper NestRebuildSchedule { get; set;}

		public SMonsterNestUpdateDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}