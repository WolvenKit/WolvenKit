using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CIdleAIEntryGenerator : CSpawnTreeBaseEntryGenerator
	{
		[Ordinal(1)] [RED("commonSpawnParams")] 		public SCreatureEntrySpawnerParams CommonSpawnParams { get; set;}

		[Ordinal(2)] [RED("entries", 2,0)] 		public CArray<SIdleAEntryGeneratorParam> Entries { get; set;}

		public CIdleAIEntryGenerator(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}