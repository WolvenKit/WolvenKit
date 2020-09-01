using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFoodBoidPointOfInterest : CBoidPointOfInterestComponentScript
	{
		[Ordinal(1)] [RED("("expirationTime")] 		public CInt32 ExpirationTime { get; set;}

		[Ordinal(2)] [RED("("useCounter")] 		public CFloat UseCounter { get; set;}

		[Ordinal(3)] [RED("("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(4)] [RED("("poiDisp")] 		public CHandle<W3POIDispenser> PoiDisp { get; set;}

		[Ordinal(5)] [RED("("poi")] 		public CHandle<W3PointOfInterestEntity> Poi { get; set;}

		public CFoodBoidPointOfInterest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFoodBoidPointOfInterest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}