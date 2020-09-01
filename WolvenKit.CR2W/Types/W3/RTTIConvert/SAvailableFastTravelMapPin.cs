using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAvailableFastTravelMapPin : CVariable
	{
		[Ordinal(0)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(0)] [RED("type")] 		public CName Type { get; set;}

		[Ordinal(0)] [RED("area")] 		public CEnum<EAreaName> Area { get; set;}

		public SAvailableFastTravelMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAvailableFastTravelMapPin(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}