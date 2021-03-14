using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneChoice : CStorySceneElement
	{
		[Ordinal(1)] [RED("choiceLines", 2,0)] 		public CArray<CPtr<CStorySceneChoiceLine>> ChoiceLines { get; set;}

		[Ordinal(2)] [RED("timeLimit")] 		public CFloat TimeLimit { get; set;}

		[Ordinal(3)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("isLooped")] 		public CBool IsLooped { get; set;}

		[Ordinal(5)] [RED("questChoice")] 		public CBool QuestChoice { get; set;}

		[Ordinal(6)] [RED("showLastLine")] 		public CBool ShowLastLine { get; set;}

		[Ordinal(7)] [RED("alternativeUI")] 		public CBool AlternativeUI { get; set;}

		public CStorySceneChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneChoice(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}