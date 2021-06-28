using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneLine : CAbstractStorySceneLine
	{
		[Ordinal(1)] [RED("dialogLine")] 		public LocalizedString DialogLine { get; set;}

		[Ordinal(2)] [RED("voiceFileName")] 		public CString VoiceFileName { get; set;}

		[Ordinal(3)] [RED("noBreak")] 		public CBool NoBreak { get; set;}

		[Ordinal(4)] [RED("soundEventName")] 		public StringAnsi SoundEventName { get; set;}

		[Ordinal(5)] [RED("disableOcclusion")] 		public CBool DisableOcclusion { get; set;}

		[Ordinal(6)] [RED("isBackgroundLine")] 		public CBool IsBackgroundLine { get; set;}

		[Ordinal(7)] [RED("alternativeUI")] 		public CBool AlternativeUI { get; set;}

		public CStorySceneLine(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}