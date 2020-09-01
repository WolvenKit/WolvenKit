using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MapMenu : CR4MenuBase
	{
		[Ordinal(0)] [RED("("m_shownArea")] 		public CEnum<EAreaName> M_shownArea { get; set;}

		[Ordinal(0)] [RED("("m_currentArea")] 		public CEnum<EAreaName> M_currentArea { get; set;}

		[Ordinal(0)] [RED("("m_fxRemoveUserMapPin")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveUserMapPin { get; set;}

		[Ordinal(0)] [RED("("m_fxSetMapZooms")] 		public CHandle<CScriptedFlashFunction> M_fxSetMapZooms { get; set;}

		[Ordinal(0)] [RED("("m_fxSetMapVisibilityBoundaries")] 		public CHandle<CScriptedFlashFunction> M_fxSetMapVisibilityBoundaries { get; set;}

		[Ordinal(0)] [RED("("m_fxSetMapScrollingBoundaries")] 		public CHandle<CScriptedFlashFunction> M_fxSetMapScrollingBoundaries { get; set;}

		[Ordinal(0)] [RED("("m_fxSetMapSettings")] 		public CHandle<CScriptedFlashFunction> M_fxSetMapSettings { get; set;}

		[Ordinal(0)] [RED("("m_fxReinitializeMap")] 		public CHandle<CScriptedFlashFunction> M_fxReinitializeMap { get; set;}

		[Ordinal(0)] [RED("("m_fxEnableDebugMode")] 		public CHandle<CScriptedFlashFunction> M_fxEnableDebugMode { get; set;}

		[Ordinal(0)] [RED("("m_fxEnableUnlimitedZoom")] 		public CHandle<CScriptedFlashFunction> M_fxEnableUnlimitedZoom { get; set;}

		[Ordinal(0)] [RED("("m_fxEnableManualLod")] 		public CHandle<CScriptedFlashFunction> M_fxEnableManualLod { get; set;}

		[Ordinal(0)] [RED("("m_fxShowBorders")] 		public CHandle<CScriptedFlashFunction> M_fxShowBorders { get; set;}

		[Ordinal(0)] [RED("("m_fxSetDefaultPosition")] 		public CHandle<CScriptedFlashFunction> M_fxSetDefaultPosition { get; set;}

		[Ordinal(0)] [RED("("m_fxShowToussaint")] 		public CHandle<CScriptedFlashFunction> M_fxShowToussaint { get; set;}

		[Ordinal(0)] [RED("("m_fxSetHighlightedMapPin")] 		public CHandle<CScriptedFlashFunction> M_fxSetHighlightedMapPin { get; set;}

		[Ordinal(0)] [RED("("m_userPinNames", 2,0)] 		public CArray<CName> M_userPinNames { get; set;}

		[Ordinal(0)] [RED("("currentTag")] 		public CName CurrentTag { get; set;}

		[Ordinal(0)] [RED("("ALL_QUEST_OBJECTIVES_ON_MAP___ANOTHER_MOD_CHANGES_MAPMENU_WS_FILE___USE_SCRIPT_MERGER_TO_DETECT_AND_FIX_THE_CONFLICT")] 		public CInt32 ALL_QUEST_OBJECTIVES_ON_MAP___ANOTHER_MOD_CHANGES_MAPMENU_WS_FILE___USE_SCRIPT_MERGER_TO_DETECT_AND_FIX_THE_CONFLICT { get; set;}

		public CR4MapMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MapMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}