using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQCHasItemGE : IGameplayEntConditionType
	{
		[Ordinal(1)] [RED("item")] 		public CName Item { get; set;}

		[Ordinal(2)] [RED("itemCategory")] 		public CName ItemCategory { get; set;}

		[Ordinal(3)] [RED("itemTag")] 		public CName ItemTag { get; set;}

		[Ordinal(4)] [RED("quantity")] 		public CUInt32 Quantity { get; set;}

		[Ordinal(5)] [RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		public CQCHasItemGE(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}