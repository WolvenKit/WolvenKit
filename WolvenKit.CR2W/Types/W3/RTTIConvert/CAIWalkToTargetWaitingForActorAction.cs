using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIWalkToTargetWaitingForActorAction : IAIActionTree
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[RED("waitForTag")] 		public CName WaitForTag { get; set;}

		[RED("timeout")] 		public CFloat Timeout { get; set;}

		[RED("testDistance")] 		public CFloat TestDistance { get; set;}

		public CAIWalkToTargetWaitingForActorAction(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIWalkToTargetWaitingForActorAction(cr2w);

	}
}