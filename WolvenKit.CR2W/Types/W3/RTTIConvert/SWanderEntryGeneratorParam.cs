using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWanderEntryGeneratorParam : CVariable
	{
		[RED("qualityMin")] 		public CInt32 QualityMin { get; set;}

		[RED("qualityMax")] 		public CInt32 QualityMax { get; set;}

		[RED("creatureDefinition")] 		public SCreatureDefinitionWrapper CreatureDefinition { get; set;}

		[RED("spawnWayPointTag")] 		public TagList SpawnWayPointTag { get; set;}

		[RED("wanderPointsGroupTag")] 		public CName WanderPointsGroupTag { get; set;}

		public SWanderEntryGeneratorParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SWanderEntryGeneratorParam(cr2w);

	}
}