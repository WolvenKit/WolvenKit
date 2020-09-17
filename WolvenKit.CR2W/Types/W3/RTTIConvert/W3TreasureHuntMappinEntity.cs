using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TreasureHuntMappinEntity : CR4MapPinEntity
	{
		[Ordinal(1)] [RED("mappinSet")] 		public CBool MappinSet { get; set;}

		[Ordinal(2)] [RED("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(3)] [RED("regionType")] 		public CEnum<EEP2PoiType> RegionType { get; set;}

		public W3TreasureHuntMappinEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TreasureHuntMappinEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}