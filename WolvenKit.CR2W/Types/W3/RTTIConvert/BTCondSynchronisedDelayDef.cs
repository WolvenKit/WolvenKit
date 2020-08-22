using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondSynchronisedDelayDef : IBehTreeConditionalTaskDefinition
	{
		[RED("delay")] 		public CFloat Delay { get; set;}

		[RED("syncEventName")] 		public CBehTreeValCName SyncEventName { get; set;}

		[RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		[RED("triggerEventOnActivate")] 		public CBool TriggerEventOnActivate { get; set;}

		[RED("triggerEventOnDeactivate")] 		public CBool TriggerEventOnDeactivate { get; set;}

		[RED("triggerEventOnSuccess")] 		public CBool TriggerEventOnSuccess { get; set;}

		[RED("triggerEventOnFailed")] 		public CBool TriggerEventOnFailed { get; set;}

		[RED("isAvailableUntilFirstEvent")] 		public CBool IsAvailableUntilFirstEvent { get; set;}

		[RED("personalSync")] 		public CBool PersonalSync { get; set;}

		public BTCondSynchronisedDelayDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondSynchronisedDelayDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}