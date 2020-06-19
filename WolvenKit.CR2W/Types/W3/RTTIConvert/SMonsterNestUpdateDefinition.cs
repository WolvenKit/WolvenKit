using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMonsterNestUpdateDefinition : CVariable
	{
		[RED("isRebuilding")] 		public CBool IsRebuilding { get; set;}

		[RED("defaultPhaseToActivate")] 		public CName DefaultPhaseToActivate { get; set;}

		[RED("bossPhaseToActivate")] 		public CName BossPhaseToActivate { get; set;}

		[RED("hasBoss")] 		public CBool HasBoss { get; set;}

		[RED("bossSpawnDelay")] 		public CFloat BossSpawnDelay { get; set;}

		[RED("nestRebuildSchedule")] 		public GameTimeWrapper NestRebuildSchedule { get; set;}

		public SMonsterNestUpdateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMonsterNestUpdateDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}