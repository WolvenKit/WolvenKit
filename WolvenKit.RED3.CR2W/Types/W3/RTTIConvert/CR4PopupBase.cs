using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PopupBase : CR4Popup
	{
		[Ordinal(1)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(2)] [RED("m_flashModule")] 		public CHandle<CScriptedFlashSprite> M_flashModule { get; set;}

		[Ordinal(3)] [RED("m_fxSetArabicAligmentMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetArabicAligmentMode { get; set;}

		[Ordinal(4)] [RED("m_fxSetGameLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLanguage { get; set;}

		[Ordinal(5)] [RED("m_fxSwapAcceptCancel")] 		public CHandle<CScriptedFlashFunction> M_fxSwapAcceptCancel { get; set;}

		[Ordinal(6)] [RED("m_fxSetControllerType")] 		public CHandle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

		[Ordinal(7)] [RED("m_fxSetPlatform")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlatform { get; set;}

		[Ordinal(8)] [RED("m_fxSetGamepadType")] 		public CHandle<CScriptedFlashFunction> M_fxSetGamepadType { get; set;}

		[Ordinal(9)] [RED("m_fxLockControlScheme")] 		public CHandle<CScriptedFlashFunction> M_fxLockControlScheme { get; set;}

		[Ordinal(10)] [RED("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		public CR4PopupBase(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}