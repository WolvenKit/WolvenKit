using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageFliesDef : IBehTreeTaskDefinition
	{
		[RED("entityToSummon")] 		public CHandle<CEntityTemplate> EntityToSummon { get; set;}

		[RED("maxFliesAlive")] 		public CInt32 MaxFliesAlive { get; set;}

		[RED("delayBetweenSpawns")] 		public SRangeF DelayBetweenSpawns { get; set;}

		[RED("delayToRespawn")] 		public SRangeF DelayToRespawn { get; set;}

		public BTTaskManageFliesDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskManageFliesDef(cr2w);

	}
}