using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMountEvent : CVariable
	{
		[RED("animEventName")] 		public CName AnimEventName { get; set;}

		[RED("entityReferenceName")] 		public CName EntityReferenceName { get; set;}

		[RED("newSlotName")] 		public CName NewSlotName { get; set;}

		[RED("entityContainingSlot")] 		public CEnum<EBgNPCType> EntityContainingSlot { get; set;}

		public SMountEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMountEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}