using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAvailableFastTravelMapPin : CVariable
	{
		[Ordinal(1)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("type")] 		public CName Type { get; set;}

		[Ordinal(3)] [RED("area")] 		public CEnum<EAreaName> Area { get; set;}

		public SAvailableFastTravelMapPin(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}