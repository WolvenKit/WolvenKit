using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GwintGameMenu : CR4GwintBaseMenu
	{
		[Ordinal(0)] [RED("("chooseTurnPopup")] 		public CHandle<W3ChooseGwintTurnPopup> ChooseTurnPopup { get; set;}

		[Ordinal(0)] [RED("("m_fxSetGwintResult")] 		public CHandle<CScriptedFlashFunction> M_fxSetGwintResult { get; set;}

		[Ordinal(0)] [RED("("m_fxSetWhoStarts")] 		public CHandle<CScriptedFlashFunction> M_fxSetWhoStarts { get; set;}

		[Ordinal(0)] [RED("("m_fxShowTutorial")] 		public CHandle<CScriptedFlashFunction> M_fxShowTutorial { get; set;}

		[Ordinal(0)] [RED("("playerWon")] 		public CBool PlayerWon { get; set;}

		[Ordinal(0)] [RED("("tutorialActive")] 		public CBool TutorialActive { get; set;}

		public CR4GwintGameMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GwintGameMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}