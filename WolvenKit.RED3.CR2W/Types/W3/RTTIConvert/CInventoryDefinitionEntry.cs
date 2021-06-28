using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInventoryDefinitionEntry : CObject
	{
		[Ordinal(1)] [RED("category")] 		public CName Category { get; set;}

		[Ordinal(2)] [RED("quantityMin")] 		public CUInt32 QuantityMin { get; set;}

		[Ordinal(3)] [RED("quantityMax")] 		public CUInt32 QuantityMax { get; set;}

		[Ordinal(4)] [RED("probability")] 		public CFloat Probability { get; set;}

		[Ordinal(5)] [RED("isMount")] 		public CBool IsMount { get; set;}

		[Ordinal(6)] [RED("isLootable")] 		public CBool IsLootable { get; set;}

		[Ordinal(7)] [RED("initializer")] 		public CPtr<IInventoryInitializer> Initializer { get; set;}

		public CInventoryDefinitionEntry(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}