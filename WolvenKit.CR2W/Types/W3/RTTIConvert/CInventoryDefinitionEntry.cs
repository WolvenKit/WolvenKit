using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInventoryDefinitionEntry : CObject
	{
		[RED("category")] 		public CName Category { get; set;}

		[RED("quantityMin")] 		public CUInt32 QuantityMin { get; set;}

		[RED("quantityMax")] 		public CUInt32 QuantityMax { get; set;}

		[RED("probability")] 		public CFloat Probability { get; set;}

		[RED("isMount")] 		public CBool IsMount { get; set;}

		[RED("isLootable")] 		public CBool IsLootable { get; set;}

		[RED("initializer")] 		public CPtr<IInventoryInitializer> Initializer { get; set;}

		public CInventoryDefinitionEntry(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CInventoryDefinitionEntry(cr2w);

	}
}