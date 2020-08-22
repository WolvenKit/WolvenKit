using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleControlsFeedback : CR4HudModuleBase
	{
		[RED("m_fxSetSwordTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetSwordTextSFF { get; set;}

		[RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[RED("m_currentInputContext")] 		public CName M_currentInputContext { get; set;}

		[RED("m_previousInputContext")] 		public CName M_previousInputContext { get; set;}

		[RED("m_currentPlayerWeapon")] 		public CEnum<EPlayerWeapon> M_currentPlayerWeapon { get; set;}

		[RED("m_displaySprint")] 		public CBool M_displaySprint { get; set;}

		[RED("m_displayJump")] 		public CBool M_displayJump { get; set;}

		[RED("m_displayCallHorse")] 		public CBool M_displayCallHorse { get; set;}

		[RED("m_displayDiveDown")] 		public CBool M_displayDiveDown { get; set;}

		[RED("m_displayGallop")] 		public CBool M_displayGallop { get; set;}

		[RED("m_displayCanter")] 		public CBool M_displayCanter { get; set;}

		[RED("m_movementLockType")] 		public CEnum<EPlayerMovementLockType> M_movementLockType { get; set;}

		[RED("m_lastUsedPCInput")] 		public CBool M_lastUsedPCInput { get; set;}

		[RED("m_CurrentHorseComp")] 		public CHandle<W3HorseComponent> M_CurrentHorseComp { get; set;}

		[RED("KEY_CONTROLS_FEEDBACK_LIST")] 		public CString KEY_CONTROLS_FEEDBACK_LIST { get; set;}

		public CR4HudModuleControlsFeedback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleControlsFeedback(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}