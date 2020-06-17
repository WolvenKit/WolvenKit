using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPinConfig : CVariable
	{
		[RED("pinTypes", 2,0)] 		public CArray<SMapPinType> PinTypes { get; set;}

		[RED("alwaysTrackedPins", 2,0)] 		public CArray<CName> AlwaysTrackedPins { get; set;}

		[RED("distantUpdateTime")] 		public CFloat DistantUpdateTime { get; set;}

		[RED("nearbyRadius")] 		public CFloat NearbyRadius { get; set;}

		public SMapPinConfig(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SMapPinConfig(cr2w);

	}
}