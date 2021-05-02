using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GlossaryEncyclopediaMenu : CR4ListBaseMenu
	{
		[Ordinal(1)] [RED("m_fxUpdateEntryInfo")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateEntryInfo { get; set;}

		[Ordinal(2)] [RED("m_fxUpdateEntryImage")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateEntryImage { get; set;}

		[Ordinal(3)] [RED("m_fxSetMovieData")] 		public CHandle<CScriptedFlashFunction> M_fxSetMovieData { get; set;}

		public CR4GlossaryEncyclopediaMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}