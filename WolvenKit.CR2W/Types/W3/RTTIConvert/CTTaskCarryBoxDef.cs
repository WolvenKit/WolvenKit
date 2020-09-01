using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTTaskCarryBoxDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("entityTemplate")] 		public CName EntityTemplate { get; set;}

		[Ordinal(0)] [RED("pickUpPoint")] 		public CBehTreeValCName PickUpPoint { get; set;}

		[Ordinal(0)] [RED("dropPoint")] 		public CBehTreeValCName DropPoint { get; set;}

		public CTTaskCarryBoxDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTTaskCarryBoxDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}