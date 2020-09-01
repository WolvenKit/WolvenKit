using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAreaLootParams : CVariable
	{
		[Ordinal(1)] [RED("remainingItemDrops", 2,0)] 		public CArray<SAreaItemDefinition> RemainingItemDrops { get; set;}

		[Ordinal(2)] [RED("areaType")] 		public CEnum<EAreaName> AreaType { get; set;}

		public SAreaLootParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAreaLootParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}