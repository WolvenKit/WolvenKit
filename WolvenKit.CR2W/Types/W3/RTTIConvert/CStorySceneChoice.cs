using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneChoice : CStorySceneElement
	{
		[RED("choiceLines", 2,0)] 		public CArray<CPtr<CStorySceneChoiceLine>> ChoiceLines { get; set;}

		[RED("timeLimit")] 		public CFloat TimeLimit { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("isLooped")] 		public CBool IsLooped { get; set;}

		[RED("questChoice")] 		public CBool QuestChoice { get; set;}

		[RED("showLastLine")] 		public CBool ShowLastLine { get; set;}

		[RED("alternativeUI")] 		public CBool AlternativeUI { get; set;}

		public CStorySceneChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneChoice(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}