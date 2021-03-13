using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4RecapMoviesMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("m_fxSetGameLogoLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLogoLanguage { get; set;}

		[Ordinal(2)] [RED("m_fxSetSubtitles")] 		public CHandle<CScriptedFlashFunction> M_fxSetSubtitles { get; set;}

		[Ordinal(3)] [RED("m_MovieData", 2,0)] 		public CArray<SMovieData> M_MovieData { get; set;}

		[Ordinal(4)] [RED("m_CurrentMovieID")] 		public CInt32 M_CurrentMovieID { get; set;}

		[Ordinal(5)] [RED("guiManager")] 		public CHandle<CR4GuiManager> GuiManager { get; set;}

		[Ordinal(6)] [RED("wasSkipped")] 		public CBool WasSkipped { get; set;}

		[Ordinal(7)] [RED("languageName")] 		public CString LanguageName { get; set;}

		public CR4RecapMoviesMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4RecapMoviesMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}