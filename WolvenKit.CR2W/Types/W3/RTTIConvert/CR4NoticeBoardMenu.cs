using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4NoticeBoardMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("board")] 		public CHandle<W3NoticeBoard> Board { get; set;}

		[Ordinal(2)] [RED("m_fxSetSelectedIndex")] 		public CHandle<CScriptedFlashFunction> M_fxSetSelectedIndex { get; set;}

		[Ordinal(3)] [RED("m_fxSetTitle")] 		public CHandle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

		[Ordinal(4)] [RED("m_fxSetDescription")] 		public CHandle<CScriptedFlashFunction> M_fxSetDescription { get; set;}

		public CR4NoticeBoardMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4NoticeBoardMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}