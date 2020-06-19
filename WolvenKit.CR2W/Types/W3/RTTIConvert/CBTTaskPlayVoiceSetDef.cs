using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayVoiceSetDef : IBehTreeTaskDefinition
	{
		[RED("voiceSet")] 		public CBehTreeValString VoiceSet { get; set;}

		[RED("priority")] 		public CBehTreeValInt Priority { get; set;}

		[RED("waitUntilSpeechIsFinished")] 		public CBool WaitUntilSpeechIsFinished { get; set;}

		[RED("randomizeSpeechStart")] 		public CBool RandomizeSpeechStart { get; set;}

		[RED("dontActivateWhileSpeaking")] 		public CBool DontActivateWhileSpeaking { get; set;}

		[RED("speachStartDelay")] 		public CFloat SpeachStartDelay { get; set;}

		[RED("playOnDeactivate")] 		public CBool PlayOnDeactivate { get; set;}

		[RED("playAfterXtimes")] 		public CInt32 PlayAfterXtimes { get; set;}

		[RED("breakCurrentSpeach")] 		public CBool BreakCurrentSpeach { get; set;}

		public CBTTaskPlayVoiceSetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayVoiceSetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}