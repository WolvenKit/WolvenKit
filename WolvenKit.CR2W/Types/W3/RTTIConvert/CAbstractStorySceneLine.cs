using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAbstractStorySceneLine : CStorySceneElement
	{
		[RED("voicetag")] 		public CName Voicetag { get; set;}

		[RED("comment")] 		public LocalizedString Comment { get; set;}

		[RED("speakingTo")] 		public CName SpeakingTo { get; set;}

		public CAbstractStorySceneLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAbstractStorySceneLine(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}