using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleRadialMenu : CR4HudModuleBase
	{
		[RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[RED("m_fxBlockRadialMenuSFF")] 		public CHandle<CScriptedFlashFunction> M_fxBlockRadialMenuSFF { get; set;}

		[RED("m_fxShowRadialMenuSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowRadialMenuSFF { get; set;}

		[RED("m_fxUpdateItemIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateItemIconSFF { get; set;}

		[RED("m_fxUpdateFieldEquippedStateSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateFieldEquippedStateSFF { get; set;}

		[RED("m_fxSetDesaturatedSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetDesaturatedSFF { get; set;}

		[RED("m_fxSetCiriRadialSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetCiriRadialSFF { get; set;}

		[RED("m_fxSetCiriItemSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetCiriItemSFF { get; set;}

		[RED("m_fxSetMeditationButtonEnabledSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMeditationButtonEnabledSFF { get; set;}

		[RED("m_fxSetSelectedItem")] 		public CHandle<CScriptedFlashFunction> M_fxSetSelectedItem { get; set;}

		[RED("m_fxSetArabicAligmentMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetArabicAligmentMode { get; set;}

		[RED("m_fxUpdateInputMode")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateInputMode { get; set;}

		[RED("m_shown")] 		public CBool M_shown { get; set;}

		[RED("m_IsPlayerCiri")] 		public CBool M_IsPlayerCiri { get; set;}

		[RED("m_isDesaturated")] 		public CBool M_isDesaturated { get; set;}

		[RED("m_HasBlink")] 		public CBool M_HasBlink { get; set;}

		[RED("m_HasCharge")] 		public CBool M_HasCharge { get; set;}

		[RED("m_allowAutoRotationReturnValue")] 		public CBool M_allowAutoRotationReturnValue { get; set;}

		[RED("m_swappedAcceptCancel")] 		public CBool M_swappedAcceptCancel { get; set;}

		[RED("m_tutorialsHidden")] 		public CBool M_tutorialsHidden { get; set;}

		[RED("_currentSelection")] 		public CString _currentSelection { get; set;}

		public CR4HudModuleRadialMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleRadialMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}