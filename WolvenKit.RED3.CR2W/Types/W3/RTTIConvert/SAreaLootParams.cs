using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAreaLootParams : CVariable
	{
		[Ordinal(1)] [RED("remainingItemDrops", 2,0)] 		public CArray<SAreaItemDefinition> RemainingItemDrops { get; set;}

		[Ordinal(2)] [RED("areaType")] 		public CEnum<EAreaName> AreaType { get; set;}

		public SAreaLootParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}