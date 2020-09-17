using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEquipmentDefinitionEntry : CObject
	{
		[Ordinal(1)] [RED("category")] 		public CName Category { get; set;}

		[Ordinal(2)] [RED("defaultItemName")] 		public CName DefaultItemName { get; set;}

		[Ordinal(3)] [RED("initializer")] 		public CPtr<IEquipmentInitializer> Initializer { get; set;}

		public CEquipmentDefinitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEquipmentDefinitionEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}