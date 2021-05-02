using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMountEvent : CVariable
	{
		[Ordinal(1)] [RED("animEventName")] 		public CName AnimEventName { get; set;}

		[Ordinal(2)] [RED("entityReferenceName")] 		public CName EntityReferenceName { get; set;}

		[Ordinal(3)] [RED("newSlotName")] 		public CName NewSlotName { get; set;}

		[Ordinal(4)] [RED("entityContainingSlot")] 		public CEnum<EBgNPCType> EntityContainingSlot { get; set;}

		public SMountEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMountEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}