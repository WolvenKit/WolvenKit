using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodePlayVoicesetOnDeactivationDecoratorDefinition : IBehTreeNodeSpeechDecoratorDefinition
	{
		[Ordinal(1)] [RED("voiceSet")] 		public CBehTreeValString VoiceSet { get; set;}

		[Ordinal(2)] [RED("voicePriority")] 		public CBehTreeValInt VoicePriority { get; set;}

		[Ordinal(3)] [RED("playAfterXTimes")] 		public CUInt16 PlayAfterXTimes { get; set;}

		[Ordinal(4)] [RED("chanceToPlay")] 		public CFloat ChanceToPlay { get; set;}

		public CBehTreeNodePlayVoicesetOnDeactivationDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodePlayVoicesetOnDeactivationDecoratorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}