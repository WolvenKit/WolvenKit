using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GlossaryTutorialsMenu : CR4ListBaseMenu
	{
		[Ordinal(1)] [RED("allEntries", 2,0)] 		public CArray<CHandle<CJournalTutorialGroup>> AllEntries { get; set;}

		[Ordinal(2)] [RED("m_fxSetTitle")] 		public CHandle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

		[Ordinal(3)] [RED("m_fxSetText")] 		public CHandle<CScriptedFlashFunction> M_fxSetText { get; set;}

		[Ordinal(4)] [RED("m_fxSetImage")] 		public CHandle<CScriptedFlashFunction> M_fxSetImage { get; set;}

		[Ordinal(5)] [RED("resetSelection")] 		public CBool ResetSelection { get; set;}

		public CR4GlossaryTutorialsMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}