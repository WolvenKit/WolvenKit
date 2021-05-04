using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageFlies : IBehTreeTask
	{
		[Ordinal(1)] [RED("entityToSummon")] 		public CHandle<CEntityTemplate> EntityToSummon { get; set;}

		[Ordinal(2)] [RED("maxFliesAlive")] 		public CInt32 MaxFliesAlive { get; set;}

		[Ordinal(3)] [RED("delayBetweenSpawns")] 		public SRangeF DelayBetweenSpawns { get; set;}

		[Ordinal(4)] [RED("delayToRespawn")] 		public SRangeF DelayToRespawn { get; set;}

		[Ordinal(5)] [RED("m_summonerCmp")] 		public CHandle<W3SummonerComponent> M_summonerCmp { get; set;}

		[Ordinal(6)] [RED("m_DelayToNextSpawn")] 		public CFloat M_DelayToNextSpawn { get; set;}

		public BTTaskManageFlies(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}