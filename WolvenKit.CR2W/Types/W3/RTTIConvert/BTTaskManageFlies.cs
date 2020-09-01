using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageFlies : IBehTreeTask
	{
		[Ordinal(0)] [RED("entityToSummon")] 		public CHandle<CEntityTemplate> EntityToSummon { get; set;}

		[Ordinal(0)] [RED("maxFliesAlive")] 		public CInt32 MaxFliesAlive { get; set;}

		[Ordinal(0)] [RED("delayBetweenSpawns")] 		public SRangeF DelayBetweenSpawns { get; set;}

		[Ordinal(0)] [RED("delayToRespawn")] 		public SRangeF DelayToRespawn { get; set;}

		[Ordinal(0)] [RED("m_summonerCmp")] 		public CHandle<W3SummonerComponent> M_summonerCmp { get; set;}

		[Ordinal(0)] [RED("m_DelayToNextSpawn")] 		public CFloat M_DelayToNextSpawn { get; set;}

		public BTTaskManageFlies(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageFlies(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}