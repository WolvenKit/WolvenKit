using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorSnapshotDataStateMachine : CVariable
	{
		[RED("stateMachineId")] 		public CUInt32 StateMachineId { get; set;}

		[RED("currentStateId")] 		public CUInt32 CurrentStateId { get; set;}

		[RED("currentStateTime")] 		public CFloat CurrentStateTime { get; set;}

		public SBehaviorSnapshotDataStateMachine(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorSnapshotDataStateMachine(cr2w);

	}
}