using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondSynchronisedDelayDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(2)] [RED("syncEventName")] 		public CBehTreeValCName SyncEventName { get; set;}

		[Ordinal(3)] [RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		[Ordinal(4)] [RED("triggerEventOnActivate")] 		public CBool TriggerEventOnActivate { get; set;}

		[Ordinal(5)] [RED("triggerEventOnDeactivate")] 		public CBool TriggerEventOnDeactivate { get; set;}

		[Ordinal(6)] [RED("triggerEventOnSuccess")] 		public CBool TriggerEventOnSuccess { get; set;}

		[Ordinal(7)] [RED("triggerEventOnFailed")] 		public CBool TriggerEventOnFailed { get; set;}

		[Ordinal(8)] [RED("isAvailableUntilFirstEvent")] 		public CBool IsAvailableUntilFirstEvent { get; set;}

		[Ordinal(9)] [RED("personalSync")] 		public CBool PersonalSync { get; set;}

		public BTCondSynchronisedDelayDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondSynchronisedDelayDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}