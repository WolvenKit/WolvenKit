using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MainCreditsMenu : CR4MenuBase
	{
		[RED("guiManager")] 		public CHandle<CR4GuiManager> GuiManager { get; set;}

		[RED("m_fxSetSectionTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetSectionTextSFF { get; set;}

		[RED("m_fxSetScrollingSpeedSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetScrollingSpeedSFF { get; set;}

		[RED("m_fxAddScrollingTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxAddScrollingTextSFF { get; set;}

		[RED("m_fxStartScrollingTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxStartScrollingTextSFF { get; set;}

		[RED("m_fxChangedConstraintedStateSFF")] 		public CHandle<CScriptedFlashFunction> M_fxChangedConstraintedStateSFF { get; set;}

		[RED("m_fxSetThankYouText")] 		public CHandle<CScriptedFlashFunction> M_fxSetThankYouText { get; set;}

		[RED("legalTextOverride")] 		public CBool LegalTextOverride { get; set;}

		[RED("shouldCloseOnMovieEnd")] 		public CBool ShouldCloseOnMovieEnd { get; set;}

		[RED("creditsSections", 2,0)] 		public CArray<CreditsSection> CreditsSections { get; set;}

		[RED("currentSectionID")] 		public CInt32 CurrentSectionID { get; set;}

		[RED("htmlNewline")] 		public CString HtmlNewline { get; set;}

		[RED("playedSecondSection")] 		public CBool PlayedSecondSection { get; set;}

		[RED("SCROLLING_TEXT_LINE_COUNT")] 		public CInt32 SCROLLING_TEXT_LINE_COUNT { get; set;}

		[RED("SCROLLING_SPEED")] 		public CInt32 SCROLLING_SPEED { get; set;}

		public CR4MainCreditsMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MainCreditsMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}