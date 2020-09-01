using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GlossaryEncyclopediaMenu : CR4ListBaseMenu
	{
		[Ordinal(1)] [RED("m_fxUpdateEntryInfo")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateEntryInfo { get; set;}

		[Ordinal(2)] [RED("m_fxUpdateEntryImage")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateEntryImage { get; set;}

		[Ordinal(3)] [RED("m_fxSetMovieData")] 		public CHandle<CScriptedFlashFunction> M_fxSetMovieData { get; set;}

		public CR4GlossaryEncyclopediaMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GlossaryEncyclopediaMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}