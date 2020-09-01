using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WmkMapMenuData : CObject
	{
		[Ordinal(0)] [RED("("merchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> MerchantPins { get; set;}

		[Ordinal(0)] [RED("("removedMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> RemovedMerchantPins { get; set;}

		[Ordinal(0)] [RED("("replacedMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> ReplacedMerchantPins { get; set;}

		[Ordinal(0)] [RED("("deletedMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> DeletedMerchantPins { get; set;}

		[Ordinal(0)] [RED("("removedSameUniqueTagMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> RemovedSameUniqueTagMerchantPins { get; set;}

		[Ordinal(0)] [RED("("replacedSameTypePosMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> ReplacedSameTypePosMerchantPins { get; set;}

		public WmkMapMenuData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new WmkMapMenuData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}