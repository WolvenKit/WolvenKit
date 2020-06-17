using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWorkEntryGenerator : CSpawnTreeBaseEntryGenerator
	{
		[RED("entries", 2,0)] 		public CArray<SWorkEntryGeneratorParam> Entries { get; set;}

		[RED("commonSpawnParams")] 		public SCreatureEntrySpawnerParams CommonSpawnParams { get; set;}

		[RED("workCategories", 2,0)] 		public CArray<SWorkCetegoriesForCreatureDefinitionEntryGeneratorParam> WorkCategories { get; set;}

		public CWorkEntryGenerator(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CWorkEntryGenerator(cr2w);

	}
}