using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWanderAndWorkEntryGenerator : CSpawnTreeBaseEntryGenerator
	{
		[Ordinal(1)] [RED("entries", 2,0)] 		public CArray<SWanderAndWorkEntryGeneratorParams> Entries { get; set;}

		[Ordinal(2)] [RED("workCategories", 2,0)] 		public CArray<SWanderWorkCetegoriesForCreatureDefinitionEntryGeneratorParam> WorkCategories { get; set;}

		[Ordinal(3)] [RED("commonSpawnParams")] 		public SCreatureEntrySpawnerParams CommonSpawnParams { get; set;}

		[Ordinal(4)] [RED("commmonWaW")] 		public SWanderAndWorkEntryGeneratorCommon CommmonWaW { get; set;}

		public CWanderAndWorkEntryGenerator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWanderAndWorkEntryGenerator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}