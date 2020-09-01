using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSceneChoice : CVariable
	{
		[Ordinal(0)] [RED("("description")] 		public CString Description { get; set;}

		[Ordinal(0)] [RED("("emphasised")] 		public CBool Emphasised { get; set;}

		[Ordinal(0)] [RED("("previouslyChoosen")] 		public CBool PreviouslyChoosen { get; set;}

		[Ordinal(0)] [RED("("disabled")] 		public CBool Disabled { get; set;}

		[Ordinal(0)] [RED("("dialogAction")] 		public CEnum<EDialogActionIcon> DialogAction { get; set;}

		[Ordinal(0)] [RED("("playGoChunk")] 		public CName PlayGoChunk { get; set;}

		public SSceneChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSceneChoice(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}