using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleItemInfo : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_currentItemSelected")] 		public SItemUniqueId M_currentItemSelected { get; set;}

		[Ordinal(2)] [RED("m_currentItemOnSlot1")] 		public SItemUniqueId M_currentItemOnSlot1 { get; set;}

		[Ordinal(3)] [RED("m_currentItemOnSlot2")] 		public SItemUniqueId M_currentItemOnSlot2 { get; set;}

		[Ordinal(4)] [RED("m_currentItemOnSlot3")] 		public SItemUniqueId M_currentItemOnSlot3 { get; set;}

		[Ordinal(5)] [RED("m_currentItemOnSlot4")] 		public SItemUniqueId M_currentItemOnSlot4 { get; set;}

		[Ordinal(6)] [RED("m_lastBoltItem")] 		public SItemUniqueId M_lastBoltItem { get; set;}

		[Ordinal(7)] [RED("m_currentItemSelectedAmmo")] 		public CInt32 M_currentItemSelectedAmmo { get; set;}

		[Ordinal(8)] [RED("m_currentItemOnSlot1Ammo")] 		public CInt32 M_currentItemOnSlot1Ammo { get; set;}

		[Ordinal(9)] [RED("m_currentItemOnSlot2Ammo")] 		public CInt32 M_currentItemOnSlot2Ammo { get; set;}

		[Ordinal(10)] [RED("m_currentItemOnSlot3Ammo")] 		public CInt32 M_currentItemOnSlot3Ammo { get; set;}

		[Ordinal(11)] [RED("m_currentItemOnSlot4Ammo")] 		public CInt32 M_currentItemOnSlot4Ammo { get; set;}

		[Ordinal(12)] [RED("m_fxEnableSFF")] 		public CHandle<CScriptedFlashFunction> M_fxEnableSFF { get; set;}

		[Ordinal(13)] [RED("m_fxUpdateElementSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateElementSFF { get; set;}

		[Ordinal(14)] [RED("m_fxHideSlotsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxHideSlotsSFF { get; set;}

		[Ordinal(15)] [RED("m_fxSetAlwaysDisplayed")] 		public CHandle<CScriptedFlashFunction> M_fxSetAlwaysDisplayed { get; set;}

		[Ordinal(16)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(17)] [RED("m_fxSetItemInfo")] 		public CHandle<CScriptedFlashFunction> M_fxSetItemInfo { get; set;}

		[Ordinal(18)] [RED("m_fxSwitchAnimation")] 		public CHandle<CScriptedFlashFunction> M_fxSwitchAnimation { get; set;}

		[Ordinal(19)] [RED("m_fxShowButtonHints")] 		public CHandle<CScriptedFlashFunction> M_fxShowButtonHints { get; set;}

		[Ordinal(20)] [RED("m_IsPlayerCiri")] 		public CBool M_IsPlayerCiri { get; set;}

		[Ordinal(21)] [RED("m_runword6Applied")] 		public CBool M_runword6Applied { get; set;}

		[Ordinal(22)] [RED("m_previousShowButtonHints")] 		public CInt32 M_previousShowButtonHints { get; set;}

		[Ordinal(23)] [RED("m_previousSetItemInfo", 2,0)] 		public CArray<SHudItemInfo> M_previousSetItemInfo { get; set;}

		public CR4HudModuleItemInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleItemInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}