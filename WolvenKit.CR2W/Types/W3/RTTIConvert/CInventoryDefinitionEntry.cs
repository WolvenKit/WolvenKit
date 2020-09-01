using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInventoryDefinitionEntry : CObject
	{
		[Ordinal(0)] [RED("category")] 		public CName Category { get; set;}

		[Ordinal(0)] [RED("quantityMin")] 		public CUInt32 QuantityMin { get; set;}

		[Ordinal(0)] [RED("quantityMax")] 		public CUInt32 QuantityMax { get; set;}

		[Ordinal(0)] [RED("probability")] 		public CFloat Probability { get; set;}

		[Ordinal(0)] [RED("isMount")] 		public CBool IsMount { get; set;}

		[Ordinal(0)] [RED("isLootable")] 		public CBool IsLootable { get; set;}

		[Ordinal(0)] [RED("initializer")] 		public CPtr<IInventoryInitializer> Initializer { get; set;}

		public CInventoryDefinitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CInventoryDefinitionEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}