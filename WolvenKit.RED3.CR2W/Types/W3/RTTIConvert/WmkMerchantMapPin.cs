using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WmkMerchantMapPin : CVariable
	{
		[Ordinal(1)] [RED("entityIdTag")] 		public IdTag EntityIdTag { get; set;}

		[Ordinal(2)] [RED("uniqueTag")] 		public CName UniqueTag { get; set;}

		[Ordinal(3)] [RED("area")] 		public CEnum<EAreaName> Area { get; set;}

		[Ordinal(4)] [RED("pin")] 		public SCommonMapPinInstance Pin { get; set;}

		[Ordinal(5)] [RED("entityTags", 2,0)] 		public CArray<CName> EntityTags { get; set;}

		public WmkMerchantMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new WmkMerchantMapPin(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}