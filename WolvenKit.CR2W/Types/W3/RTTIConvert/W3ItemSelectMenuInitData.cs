using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ItemSelectMenuInitData : CObject
	{
		[Ordinal(1)] [RED("onlyEquipped")] 		public CBool OnlyEquipped { get; set;}

		[Ordinal(2)] [RED("onlyUnequipped")] 		public CBool OnlyUnequipped { get; set;}

		[Ordinal(3)] [RED("containTags", 2,0)] 		public CArray<CName> ContainTags { get; set;}

		public W3ItemSelectMenuInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ItemSelectMenuInitData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}