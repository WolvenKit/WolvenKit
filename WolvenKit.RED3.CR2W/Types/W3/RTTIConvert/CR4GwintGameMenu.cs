using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GwintGameMenu : CR4GwintBaseMenu
	{
		[Ordinal(1)] [RED("chooseTurnPopup")] 		public CHandle<W3ChooseGwintTurnPopup> ChooseTurnPopup { get; set;}

		[Ordinal(2)] [RED("m_fxSetGwintResult")] 		public CHandle<CScriptedFlashFunction> M_fxSetGwintResult { get; set;}

		[Ordinal(3)] [RED("m_fxSetWhoStarts")] 		public CHandle<CScriptedFlashFunction> M_fxSetWhoStarts { get; set;}

		[Ordinal(4)] [RED("m_fxShowTutorial")] 		public CHandle<CScriptedFlashFunction> M_fxShowTutorial { get; set;}

		[Ordinal(5)] [RED("playerWon")] 		public CBool PlayerWon { get; set;}

		[Ordinal(6)] [RED("tutorialActive")] 		public CBool TutorialActive { get; set;}

		public CR4GwintGameMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}