using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayVoiceSetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("voiceSet")] 		public CBehTreeValString VoiceSet { get; set;}

		[Ordinal(2)] [RED("priority")] 		public CBehTreeValInt Priority { get; set;}

		[Ordinal(3)] [RED("waitUntilSpeechIsFinished")] 		public CBool WaitUntilSpeechIsFinished { get; set;}

		[Ordinal(4)] [RED("randomizeSpeechStart")] 		public CBool RandomizeSpeechStart { get; set;}

		[Ordinal(5)] [RED("dontActivateWhileSpeaking")] 		public CBool DontActivateWhileSpeaking { get; set;}

		[Ordinal(6)] [RED("speachStartDelay")] 		public CFloat SpeachStartDelay { get; set;}

		[Ordinal(7)] [RED("playOnDeactivate")] 		public CBool PlayOnDeactivate { get; set;}

		[Ordinal(8)] [RED("playAfterXtimes")] 		public CInt32 PlayAfterXtimes { get; set;}

		[Ordinal(9)] [RED("breakCurrentSpeach")] 		public CBool BreakCurrentSpeach { get; set;}

		public CBTTaskPlayVoiceSetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayVoiceSetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}