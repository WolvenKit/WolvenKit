using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodePlayVoicesetOnDeactivationDecoratorDefinition : IBehTreeNodeSpeechDecoratorDefinition
	{
		[RED("voiceSet")] 		public CBehTreeValString VoiceSet { get; set;}

		[RED("voicePriority")] 		public CBehTreeValInt VoicePriority { get; set;}

		[RED("playAfterXTimes")] 		public CUInt16 PlayAfterXTimes { get; set;}

		[RED("chanceToPlay")] 		public CFloat ChanceToPlay { get; set;}

		public CBehTreeNodePlayVoicesetOnDeactivationDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodePlayVoicesetOnDeactivationDecoratorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}