using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionToCollision : CBTTaskCollisionMonitor
	{
		[Ordinal(1)] [RED("waitTimeout")] 		public CFloat WaitTimeout { get; set;}

		[Ordinal(2)] [RED("activationTimeout")] 		public CFloat ActivationTimeout { get; set;}

		[Ordinal(3)] [RED("knockdownDuration")] 		public CFloat KnockdownDuration { get; set;}

		[Ordinal(4)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(5)] [RED("receivedEvent")] 		public CBool ReceivedEvent { get; set;}

		[Ordinal(6)] [RED("isInCorrectBehGraphNode")] 		public CBool IsInCorrectBehGraphNode { get; set;}

		[Ordinal(7)] [RED("activationScriptEvent")] 		public CName ActivationScriptEvent { get; set;}

		[Ordinal(8)] [RED("deactivateScriptEvent")] 		public CName DeactivateScriptEvent { get; set;}

		public CBTTaskReactionToCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionToCollision(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}