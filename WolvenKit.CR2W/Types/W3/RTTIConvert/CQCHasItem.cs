using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQCHasItem : CQCActorInventory
	{
		[Ordinal(0)] [RED("item")] 		public CName Item { get; set;}

		[Ordinal(0)] [RED("itemCategory")] 		public CName ItemCategory { get; set;}

		[Ordinal(0)] [RED("itemTag")] 		public CName ItemTag { get; set;}

		[Ordinal(0)] [RED("quantity")] 		public CUInt32 Quantity { get; set;}

		[Ordinal(0)] [RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		public CQCHasItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQCHasItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}