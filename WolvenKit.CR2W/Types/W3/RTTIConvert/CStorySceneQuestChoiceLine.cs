using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneQuestChoiceLine : CStorySceneComment
	{
		[RED("emphasisLine")] 		public CBool EmphasisLine { get; set;}

		[RED("returnToChoice")] 		public CBool ReturnToChoice { get; set;}

		[RED("action")] 		public CPtr<IStorySceneChoiceLineAction> Action { get; set;}

		public CStorySceneQuestChoiceLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneQuestChoiceLine(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}