using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TreasureHuntMappinEntity : CR4MapPinEntity
	{
		[Ordinal(1)] [RED("mappinSet")] 		public CBool MappinSet { get; set;}

		[Ordinal(2)] [RED("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(3)] [RED("regionType")] 		public CEnum<EEP2PoiType> RegionType { get; set;}

		public W3TreasureHuntMappinEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}