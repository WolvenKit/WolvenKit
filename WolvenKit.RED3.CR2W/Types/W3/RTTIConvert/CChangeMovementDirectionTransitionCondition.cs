using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CChangeMovementDirectionTransitionCondition : IBehaviorStateTransitionCondition
	{
		[Ordinal(1)] [RED("angleDiffThreshold")] 		public CFloat AngleDiffThreshold { get; set;}

		[Ordinal(2)] [RED("startCheckingAfterTime")] 		public CFloat StartCheckingAfterTime { get; set;}

		[Ordinal(3)] [RED("requestedMovementDirectionWSVariableName")] 		public CName RequestedMovementDirectionWSVariableName { get; set;}

		[Ordinal(4)] [RED("currentMovementDirectionMSInternalVariableName")] 		public CName CurrentMovementDirectionMSInternalVariableName { get; set;}

		public CChangeMovementDirectionTransitionCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}