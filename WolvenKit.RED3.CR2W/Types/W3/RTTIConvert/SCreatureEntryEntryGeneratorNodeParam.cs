using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCreatureEntryEntryGeneratorNodeParam : CVariable
	{
		[Ordinal(1)] [RED("comment")] 		public CString Comment { get; set;}

		[Ordinal(2)] [RED("qualityMin")] 		public CInt32 QualityMin { get; set;}

		[Ordinal(3)] [RED("qualityMax")] 		public CInt32 QualityMax { get; set;}

		[Ordinal(4)] [RED("spawnWayPointTag")] 		public TagList SpawnWayPointTag { get; set;}

		[Ordinal(5)] [RED("creatureDefinition")] 		public SCreatureDefinitionWrapper CreatureDefinition { get; set;}

		[Ordinal(6)] [RED("appearanceName")] 		public CName AppearanceName { get; set;}

		[Ordinal(7)] [RED("tagToAssign")] 		public CName TagToAssign { get; set;}

		[Ordinal(8)] [RED("group")] 		public CInt32 Group { get; set;}

		public SCreatureEntryEntryGeneratorNodeParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCreatureEntryEntryGeneratorNodeParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}