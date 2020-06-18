using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WmkMerchantMapPin : CVariable
	{
		[RED("entityIdTag")] 		public IdTag EntityIdTag { get; set;}

		[RED("uniqueTag")] 		public CName UniqueTag { get; set;}

		[RED("area")] 		public CEnum<EAreaName> Area { get; set;}

		[RED("pin")] 		public SCommonMapPinInstance Pin { get; set;}

		[RED("entityTags", 2,0)] 		public CArray<CName> EntityTags { get; set;}

		public WmkMerchantMapPin(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new WmkMerchantMapPin(cr2w);

	}
}