using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneQuestChoiceLine : CStorySceneComment
	{
		[Ordinal(1)] [RED("emphasisLine")] 		public CBool EmphasisLine { get; set;}

		[Ordinal(2)] [RED("returnToChoice")] 		public CBool ReturnToChoice { get; set;}

		[Ordinal(3)] [RED("action")] 		public CPtr<IStorySceneChoiceLineAction> Action { get; set;}

		public CStorySceneQuestChoiceLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneQuestChoiceLine(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}