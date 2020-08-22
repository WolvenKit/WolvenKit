using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleMinimap2 : CR4HudModuleBase
	{
		[RED("MINIMAP_EXTERIOR_ZOOM")] 		public CFloat MINIMAP_EXTERIOR_ZOOM { get; set;}

		[RED("MINIMAP_INTERIOR_ZOOM")] 		public CFloat MINIMAP_INTERIOR_ZOOM { get; set;}

		[RED("MINIMAP_BOAT_ZOOM")] 		public CFloat MINIMAP_BOAT_ZOOM { get; set;}

		[RED("HINT_WAYPOINTS_MAX_REMOVAL_DISTANCE")] 		public CFloat HINT_WAYPOINTS_MAX_REMOVAL_DISTANCE { get; set;}

		[RED("HINT_WAYPOINTS_MIN_PLACING_DISTANCE")] 		public CFloat HINT_WAYPOINTS_MIN_PLACING_DISTANCE { get; set;}

		[RED("HINT_WAYPOINTS_REFRESH_INTERVAL")] 		public CFloat HINT_WAYPOINTS_REFRESH_INTERVAL { get; set;}

		[RED("HINT_WAYPOINTS_PATHFIND_TOLERANCE")] 		public CFloat HINT_WAYPOINTS_PATHFIND_TOLERANCE { get; set;}

		[RED("HINT_WAYPOINTS_MAX_COUNT")] 		public CInt32 HINT_WAYPOINTS_MAX_COUNT { get; set;}

		[RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[RED("m_fxSetMapSettingsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMapSettingsSFF { get; set;}

		[RED("m_fxSetTextureExtensionsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetTextureExtensionsSFF { get; set;}

		[RED("m_fxSetZoomSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetZoomSFF { get; set;}

		[RED("m_fxSetPlayerRotationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerRotationSFF { get; set;}

		[RED("m_fxSetPlayerPositionSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerPositionSFF { get; set;}

		[RED("m_fxSetPlayerPositionAndRotationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerPositionAndRotationSFF { get; set;}

		[RED("m_fxNotifyPlayerEnteredInteriorSFF")] 		public CHandle<CScriptedFlashFunction> M_fxNotifyPlayerEnteredInteriorSFF { get; set;}

		[RED("m_fxNotifyPlayerExitedInteriorSFF")] 		public CHandle<CScriptedFlashFunction> M_fxNotifyPlayerExitedInteriorSFF { get; set;}

		[RED("m_fxDoFadingSFF")] 		public CHandle<CScriptedFlashFunction> M_fxDoFadingSFF { get; set;}

		[RED("m_fxEnableRotationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxEnableRotationSFF { get; set;}

		[RED("m_fxEnableMask")] 		public CHandle<CScriptedFlashFunction> M_fxEnableMask { get; set;}

		[RED("m_fxEnableDebug")] 		public CHandle<CScriptedFlashFunction> M_fxEnableDebug { get; set;}

		[RED("m_fxEnableBorders")] 		public CHandle<CScriptedFlashFunction> M_fxEnableBorders { get; set;}

		[RED("m_previousPlayerPosition")] 		public Vector M_previousPlayerPosition { get; set;}

		[RED("m_previousPlayerAngle")] 		public CFloat M_previousPlayerAngle { get; set;}

		[RED("m_previousCameraAngle")] 		public CFloat M_previousCameraAngle { get; set;}

		[RED("m_zoomValue")] 		public CFloat M_zoomValue { get; set;}

		[RED("m_forceUpdate")] 		public CBool M_forceUpdate { get; set;}

		[RED("m_updateInterval")] 		public CFloat M_updateInterval { get; set;}

		[RED("m_fadedOut")] 		public CBool M_fadedOut { get; set;}

		[RED("m_weatherType")] 		public CName M_weatherType { get; set;}

		[RED("m_gameHour")] 		public CInt32 M_gameHour { get; set;}

		[RED("m_gameMin")] 		public CInt32 M_gameMin { get; set;}

		[RED("m_buffedMonsterIconPath")] 		public CName M_buffedMonsterIconPath { get; set;}

		[RED("m_dayTimeName")] 		public CName M_dayTimeName { get; set;}

		[RED("PLAYER_ANGLE_EPSILON")] 		public CFloat PLAYER_ANGLE_EPSILON { get; set;}

		[RED("CAMERA_ANGLE_EPSILON")] 		public CFloat CAMERA_ANGLE_EPSILON { get; set;}

		[RED("GAME_HOUR_DAWN")] 		public CInt32 GAME_HOUR_DAWN { get; set;}

		[RED("GAME_HOUR_DAY")] 		public CInt32 GAME_HOUR_DAY { get; set;}

		[RED("GAME_HOUR_DUSK")] 		public CInt32 GAME_HOUR_DUSK { get; set;}

		[RED("GAME_HOUR_NIGHT")] 		public CInt32 GAME_HOUR_NIGHT { get; set;}

		[RED("b24HRFormat")] 		public CBool B24HRFormat { get; set;}

		[RED("bDisplayDayTime")] 		public CBool BDisplayDayTime { get; set;}

		[RED("bDisplayBuffedMoster")] 		public CBool BDisplayBuffedMoster { get; set;}

		public CR4HudModuleMinimap2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleMinimap2(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}