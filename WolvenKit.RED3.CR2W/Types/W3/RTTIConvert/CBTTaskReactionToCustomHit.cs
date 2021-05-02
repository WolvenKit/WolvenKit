using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionToCustomHit : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(2)] [RED("waitTimeout")] 		public CFloat WaitTimeout { get; set;}

		[Ordinal(3)] [RED("activationTimeout")] 		public CFloat ActivationTimeout { get; set;}

		[Ordinal(4)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(5)] [RED("receivedEvent")] 		public CBool ReceivedEvent { get; set;}

		[Ordinal(6)] [RED("isInCorrectBehGraphNode")] 		public CBool IsInCorrectBehGraphNode { get; set;}

		[Ordinal(7)] [RED("activationScriptEvent")] 		public CName ActivationScriptEvent { get; set;}

		[Ordinal(8)] [RED("deactivateScriptEvent")] 		public CName DeactivateScriptEvent { get; set;}

		public CBTTaskReactionToCustomHit(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}