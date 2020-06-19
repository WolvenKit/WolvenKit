using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPayStorySceneChoiceAction : CStorySceneChoiceLineActionScripted
	{
		[RED("money")] 		public CInt32 Money { get; set;}

		[RED("dontGrantExp")] 		public CBool DontGrantExp { get; set;}

		[RED("actionIcon")] 		public CEnum<EDialogActionIcon> ActionIcon { get; set;}

		public CPayStorySceneChoiceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPayStorySceneChoiceAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}