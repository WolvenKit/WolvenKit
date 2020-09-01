using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAICarryMiscreantActionTree : IAICustomActionTree
	{
		[Ordinal(1)] [RED("attachmentBone")] 		public CName AttachmentBone { get; set;}

		[Ordinal(2)] [RED("miscreantName")] 		public CName MiscreantName { get; set;}

		[Ordinal(3)] [RED("behaviorGraph")] 		public CName BehaviorGraph { get; set;}

		[Ordinal(4)] [RED("cryStartEventName")] 		public CName CryStartEventName { get; set;}

		[Ordinal(5)] [RED("cryStopEventName")] 		public CName CryStopEventName { get; set;}

		[Ordinal(6)] [RED("carrySubAction")] 		public CHandle<IAIActionTree> CarrySubAction { get; set;}

		public CAICarryMiscreantActionTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAICarryMiscreantActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}