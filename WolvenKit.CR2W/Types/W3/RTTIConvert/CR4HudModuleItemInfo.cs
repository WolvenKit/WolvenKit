using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleItemInfo : CR4HudModuleBase
	{
		[RED("m_currentItemSelected")] 		public SItemUniqueId M_currentItemSelected { get; set;}

		[RED("m_currentItemOnSlot1")] 		public SItemUniqueId M_currentItemOnSlot1 { get; set;}

		[RED("m_currentItemOnSlot2")] 		public SItemUniqueId M_currentItemOnSlot2 { get; set;}

		[RED("m_currentItemOnSlot3")] 		public SItemUniqueId M_currentItemOnSlot3 { get; set;}

		[RED("m_currentItemOnSlot4")] 		public SItemUniqueId M_currentItemOnSlot4 { get; set;}

		[RED("m_lastBoltItem")] 		public SItemUniqueId M_lastBoltItem { get; set;}

		[RED("m_currentItemSelectedAmmo")] 		public CInt32 M_currentItemSelectedAmmo { get; set;}

		[RED("m_currentItemOnSlot1Ammo")] 		public CInt32 M_currentItemOnSlot1Ammo { get; set;}

		[RED("m_currentItemOnSlot2Ammo")] 		public CInt32 M_currentItemOnSlot2Ammo { get; set;}

		[RED("m_currentItemOnSlot3Ammo")] 		public CInt32 M_currentItemOnSlot3Ammo { get; set;}

		[RED("m_currentItemOnSlot4Ammo")] 		public CInt32 M_currentItemOnSlot4Ammo { get; set;}

		[RED("m_fxEnableSFF")] 		public CHandle<CScriptedFlashFunction> M_fxEnableSFF { get; set;}

		[RED("m_fxUpdateElementSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateElementSFF { get; set;}

		[RED("m_fxHideSlotsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxHideSlotsSFF { get; set;}

		[RED("m_fxSetAlwaysDisplayed")] 		public CHandle<CScriptedFlashFunction> M_fxSetAlwaysDisplayed { get; set;}

		[RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[RED("m_fxSetItemInfo")] 		public CHandle<CScriptedFlashFunction> M_fxSetItemInfo { get; set;}

		[RED("m_fxSwitchAnimation")] 		public CHandle<CScriptedFlashFunction> M_fxSwitchAnimation { get; set;}

		[RED("m_fxShowButtonHints")] 		public CHandle<CScriptedFlashFunction> M_fxShowButtonHints { get; set;}

		[RED("m_IsPlayerCiri")] 		public CBool M_IsPlayerCiri { get; set;}

		[RED("m_runword6Applied")] 		public CBool M_runword6Applied { get; set;}

		[RED("m_previousShowButtonHints")] 		public CInt32 M_previousShowButtonHints { get; set;}

		[RED("m_previousSetItemInfo", 2,0)] 		public CArray<SHudItemInfo> M_previousSetItemInfo { get; set;}

		public CR4HudModuleItemInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleItemInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}