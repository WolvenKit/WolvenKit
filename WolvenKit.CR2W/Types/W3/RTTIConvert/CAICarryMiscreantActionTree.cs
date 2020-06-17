using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAICarryMiscreantActionTree : IAICustomActionTree
	{
		[RED("attachmentBone")] 		public CName AttachmentBone { get; set;}

		[RED("miscreantName")] 		public CName MiscreantName { get; set;}

		[RED("behaviorGraph")] 		public CName BehaviorGraph { get; set;}

		[RED("cryStartEventName")] 		public CName CryStartEventName { get; set;}

		[RED("cryStopEventName")] 		public CName CryStopEventName { get; set;}

		[RED("carrySubAction")] 		public CHandle<IAIActionTree> CarrySubAction { get; set;}

		public CAICarryMiscreantActionTree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAICarryMiscreantActionTree(cr2w);

	}
}