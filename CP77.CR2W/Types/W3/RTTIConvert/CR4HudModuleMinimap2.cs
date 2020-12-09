using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleMinimap2 : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("MINIMAP_EXTERIOR_ZOOM")] 		public CFloat MINIMAP_EXTERIOR_ZOOM { get; set;}

		[Ordinal(2)] [RED("MINIMAP_INTERIOR_ZOOM")] 		public CFloat MINIMAP_INTERIOR_ZOOM { get; set;}

		[Ordinal(3)] [RED("MINIMAP_BOAT_ZOOM")] 		public CFloat MINIMAP_BOAT_ZOOM { get; set;}

		[Ordinal(4)] [RED("HINT_WAYPOINTS_MAX_REMOVAL_DISTANCE")] 		public CFloat HINT_WAYPOINTS_MAX_REMOVAL_DISTANCE { get; set;}

		[Ordinal(5)] [RED("HINT_WAYPOINTS_MIN_PLACING_DISTANCE")] 		public CFloat HINT_WAYPOINTS_MIN_PLACING_DISTANCE { get; set;}

		[Ordinal(6)] [RED("HINT_WAYPOINTS_REFRESH_INTERVAL")] 		public CFloat HINT_WAYPOINTS_REFRESH_INTERVAL { get; set;}

		[Ordinal(7)] [RED("HINT_WAYPOINTS_PATHFIND_TOLERANCE")] 		public CFloat HINT_WAYPOINTS_PATHFIND_TOLERANCE { get; set;}

		[Ordinal(8)] [RED("HINT_WAYPOINTS_MAX_COUNT")] 		public CInt32 HINT_WAYPOINTS_MAX_COUNT { get; set;}

		[Ordinal(9)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(10)] [RED("m_fxSetMapSettingsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMapSettingsSFF { get; set;}

		[Ordinal(11)] [RED("m_fxSetTextureExtensionsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetTextureExtensionsSFF { get; set;}

		[Ordinal(12)] [RED("m_fxSetZoomSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetZoomSFF { get; set;}

		[Ordinal(13)] [RED("m_fxSetPlayerRotationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerRotationSFF { get; set;}

		[Ordinal(14)] [RED("m_fxSetPlayerPositionSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerPositionSFF { get; set;}

		[Ordinal(15)] [RED("m_fxSetPlayerPositionAndRotationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerPositionAndRotationSFF { get; set;}

		[Ordinal(16)] [RED("m_fxNotifyPlayerEnteredInteriorSFF")] 		public CHandle<CScriptedFlashFunction> M_fxNotifyPlayerEnteredInteriorSFF { get; set;}

		[Ordinal(17)] [RED("m_fxNotifyPlayerExitedInteriorSFF")] 		public CHandle<CScriptedFlashFunction> M_fxNotifyPlayerExitedInteriorSFF { get; set;}

		[Ordinal(18)] [RED("m_fxDoFadingSFF")] 		public CHandle<CScriptedFlashFunction> M_fxDoFadingSFF { get; set;}

		[Ordinal(19)] [RED("m_fxEnableRotationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxEnableRotationSFF { get; set;}

		[Ordinal(20)] [RED("m_fxEnableMask")] 		public CHandle<CScriptedFlashFunction> M_fxEnableMask { get; set;}

		[Ordinal(21)] [RED("m_fxEnableDebug")] 		public CHandle<CScriptedFlashFunction> M_fxEnableDebug { get; set;}

		[Ordinal(22)] [RED("m_fxEnableBorders")] 		public CHandle<CScriptedFlashFunction> M_fxEnableBorders { get; set;}

		[Ordinal(23)] [RED("m_previousPlayerPosition")] 		public Vector M_previousPlayerPosition { get; set;}

		[Ordinal(24)] [RED("m_previousPlayerAngle")] 		public CFloat M_previousPlayerAngle { get; set;}

		[Ordinal(25)] [RED("m_previousCameraAngle")] 		public CFloat M_previousCameraAngle { get; set;}

		[Ordinal(26)] [RED("m_zoomValue")] 		public CFloat M_zoomValue { get; set;}

		[Ordinal(27)] [RED("m_forceUpdate")] 		public CBool M_forceUpdate { get; set;}

		[Ordinal(28)] [RED("m_updateInterval")] 		public CFloat M_updateInterval { get; set;}

		[Ordinal(29)] [RED("m_fadedOut")] 		public CBool M_fadedOut { get; set;}

		[Ordinal(30)] [RED("m_weatherType")] 		public CName M_weatherType { get; set;}

		[Ordinal(31)] [RED("m_gameHour")] 		public CInt32 M_gameHour { get; set;}

		[Ordinal(32)] [RED("m_gameMin")] 		public CInt32 M_gameMin { get; set;}

		[Ordinal(33)] [RED("m_buffedMonsterIconPath")] 		public CName M_buffedMonsterIconPath { get; set;}

		[Ordinal(34)] [RED("m_dayTimeName")] 		public CName M_dayTimeName { get; set;}

		[Ordinal(35)] [RED("PLAYER_ANGLE_EPSILON")] 		public CFloat PLAYER_ANGLE_EPSILON { get; set;}

		[Ordinal(36)] [RED("CAMERA_ANGLE_EPSILON")] 		public CFloat CAMERA_ANGLE_EPSILON { get; set;}

		[Ordinal(37)] [RED("GAME_HOUR_DAWN")] 		public CInt32 GAME_HOUR_DAWN { get; set;}

		[Ordinal(38)] [RED("GAME_HOUR_DAY")] 		public CInt32 GAME_HOUR_DAY { get; set;}

		[Ordinal(39)] [RED("GAME_HOUR_DUSK")] 		public CInt32 GAME_HOUR_DUSK { get; set;}

		[Ordinal(40)] [RED("GAME_HOUR_NIGHT")] 		public CInt32 GAME_HOUR_NIGHT { get; set;}

		[Ordinal(41)] [RED("b24HRFormat")] 		public CBool B24HRFormat { get; set;}

		[Ordinal(42)] [RED("bDisplayDayTime")] 		public CBool BDisplayDayTime { get; set;}

		[Ordinal(43)] [RED("bDisplayBuffedMoster")] 		public CBool BDisplayBuffedMoster { get; set;}

		public CR4HudModuleMinimap2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleMinimap2(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}