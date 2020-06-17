using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSoundAmbientDynamicSoundEvents : CVariable
	{
		[RED("eventName")] 		public StringAnsi EventName { get; set;}

		[RED("repeatTime")] 		public CFloat RepeatTime { get; set;}

		[RED("repeatTimeVariance")] 		public CFloat RepeatTimeVariance { get; set;}

		[RED("triggerOnActivation")] 		public CBool TriggerOnActivation { get; set;}

		public SSoundAmbientDynamicSoundEvents(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSoundAmbientDynamicSoundEvents(cr2w);

	}
}