using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCreatureEntryEntryGeneratorNodeParam : CVariable
	{
		[RED("comment")] 		public CString Comment { get; set;}

		[RED("qualityMin")] 		public CInt32 QualityMin { get; set;}

		[RED("qualityMax")] 		public CInt32 QualityMax { get; set;}

		[RED("spawnWayPointTag")] 		public TagList SpawnWayPointTag { get; set;}

		[RED("creatureDefinition")] 		public SCreatureDefinitionWrapper CreatureDefinition { get; set;}

		[RED("appearanceName")] 		public CName AppearanceName { get; set;}

		[RED("tagToAssign")] 		public CName TagToAssign { get; set;}

		[RED("group")] 		public CInt32 Group { get; set;}

		public SCreatureEntryEntryGeneratorNodeParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCreatureEntryEntryGeneratorNodeParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}