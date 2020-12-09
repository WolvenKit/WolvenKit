using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPinConfig : CVariable
	{
		[Ordinal(1)] [RED("pinTypes", 2,0)] 		public CArray<SMapPinType> PinTypes { get; set;}

		[Ordinal(2)] [RED("alwaysTrackedPins", 2,0)] 		public CArray<CName> AlwaysTrackedPins { get; set;}

		[Ordinal(3)] [RED("distantUpdateTime")] 		public CFloat DistantUpdateTime { get; set;}

		[Ordinal(4)] [RED("nearbyRadius")] 		public CFloat NearbyRadius { get; set;}

		public SMapPinConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMapPinConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}