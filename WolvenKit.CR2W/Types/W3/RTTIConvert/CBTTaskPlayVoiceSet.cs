using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayVoiceSet : IBehTreeTask
	{
		[RED("voiceSet")] 		public CString VoiceSet { get; set;}

		[RED("priority")] 		public CInt32 Priority { get; set;}

		[RED("waitUntilSpeechIsFinished")] 		public CBool WaitUntilSpeechIsFinished { get; set;}

		[RED("randomizeSpeechStart")] 		public CBool RandomizeSpeechStart { get; set;}

		[RED("dontActivateWhileSpeaking")] 		public CBool DontActivateWhileSpeaking { get; set;}

		[RED("speachStartDelay")] 		public CFloat SpeachStartDelay { get; set;}

		[RED("playOnDeactivate")] 		public CBool PlayOnDeactivate { get; set;}

		[RED("playAfterXtimes")] 		public CInt32 PlayAfterXtimes { get; set;}

		[RED("breakCurrentSpeach")] 		public CBool BreakCurrentSpeach { get; set;}

		[RED("iterator")] 		public CInt32 Iterator { get; set;}

		public CBTTaskPlayVoiceSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayVoiceSet(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}