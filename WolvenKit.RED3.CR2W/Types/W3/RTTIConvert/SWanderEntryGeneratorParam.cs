using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWanderEntryGeneratorParam : CVariable
	{
		[Ordinal(1)] [RED("qualityMin")] 		public CInt32 QualityMin { get; set;}

		[Ordinal(2)] [RED("qualityMax")] 		public CInt32 QualityMax { get; set;}

		[Ordinal(3)] [RED("creatureDefinition")] 		public SCreatureDefinitionWrapper CreatureDefinition { get; set;}

		[Ordinal(4)] [RED("spawnWayPointTag")] 		public TagList SpawnWayPointTag { get; set;}

		[Ordinal(5)] [RED("wanderPointsGroupTag")] 		public CName WanderPointsGroupTag { get; set;}

		public SWanderEntryGeneratorParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}