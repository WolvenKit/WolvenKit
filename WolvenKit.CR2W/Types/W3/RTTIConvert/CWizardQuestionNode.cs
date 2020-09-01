using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWizardQuestionNode : CWizardBaseNode
	{
		[Ordinal(0)] [RED("uniqueName")] 		public CName UniqueName { get; set;}

		[Ordinal(0)] [RED("layoutTemplate")] 		public CString LayoutTemplate { get; set;}

		[Ordinal(0)] [RED("text")] 		public CString Text { get; set;}

		[Ordinal(0)] [RED("optional")] 		public CBool Optional { get; set;}

		[Ordinal(0)] [RED("endNode")] 		public CBool EndNode { get; set;}

		public CWizardQuestionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWizardQuestionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}