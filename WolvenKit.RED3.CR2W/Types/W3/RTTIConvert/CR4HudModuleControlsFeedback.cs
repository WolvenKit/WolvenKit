using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleControlsFeedback : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetSwordTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetSwordTextSFF { get; set;}

		[Ordinal(2)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(3)] [RED("m_currentInputContext")] 		public CName M_currentInputContext { get; set;}

		[Ordinal(4)] [RED("m_previousInputContext")] 		public CName M_previousInputContext { get; set;}

		[Ordinal(5)] [RED("m_currentPlayerWeapon")] 		public CEnum<EPlayerWeapon> M_currentPlayerWeapon { get; set;}

		[Ordinal(6)] [RED("m_displaySprint")] 		public CBool M_displaySprint { get; set;}

		[Ordinal(7)] [RED("m_displayJump")] 		public CBool M_displayJump { get; set;}

		[Ordinal(8)] [RED("m_displayCallHorse")] 		public CBool M_displayCallHorse { get; set;}

		[Ordinal(9)] [RED("m_displayDiveDown")] 		public CBool M_displayDiveDown { get; set;}

		[Ordinal(10)] [RED("m_displayGallop")] 		public CBool M_displayGallop { get; set;}

		[Ordinal(11)] [RED("m_displayCanter")] 		public CBool M_displayCanter { get; set;}

		[Ordinal(12)] [RED("m_movementLockType")] 		public CEnum<EPlayerMovementLockType> M_movementLockType { get; set;}

		[Ordinal(13)] [RED("m_lastUsedPCInput")] 		public CBool M_lastUsedPCInput { get; set;}

		[Ordinal(14)] [RED("m_CurrentHorseComp")] 		public CHandle<W3HorseComponent> M_CurrentHorseComp { get; set;}

		[Ordinal(15)] [RED("KEY_CONTROLS_FEEDBACK_LIST")] 		public CString KEY_CONTROLS_FEEDBACK_LIST { get; set;}

		public CR4HudModuleControlsFeedback(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}