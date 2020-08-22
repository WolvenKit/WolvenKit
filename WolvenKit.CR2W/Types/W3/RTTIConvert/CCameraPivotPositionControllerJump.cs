using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraPivotPositionControllerJump : ICustomCameraScriptedPivotPositionController
	{
		[RED("useExactCamera")] 		public CBool UseExactCamera { get; set;}

		[RED("originalOffset")] 		public Vector OriginalOffset { get; set;}

		[RED("zOffset")] 		public CFloat ZOffset { get; set;}

		[RED("originalPosition")] 		public Vector OriginalPosition { get; set;}

		[RED("originalHeight")] 		public CFloat OriginalHeight { get; set;}

		[RED("blendXYSpeed")] 		public CFloat BlendXYSpeed { get; set;}

		[RED("blendXYSpeedWithTime")] 		public CBool BlendXYSpeedWithTime { get; set;}

		[RED("blendXYSpeedTimeStart")] 		public CFloat BlendXYSpeedTimeStart { get; set;}

		[RED("blendXYSpeedTimeEnd")] 		public CFloat BlendXYSpeedTimeEnd { get; set;}

		[RED("blendXYSpeedMin")] 		public CFloat BlendXYSpeedMin { get; set;}

		[RED("blendXYSpeedMax")] 		public CFloat BlendXYSpeedMax { get; set;}

		[RED("blendZSpeedStart")] 		public CFloat BlendZSpeedStart { get; set;}

		[RED("blendZSpeedEnd")] 		public CFloat BlendZSpeedEnd { get; set;}

		[RED("blendCurve")] 		public CHandle<CCurve> BlendCurve { get; set;}

		[RED("blendZBasedOn")] 		public CEnum<ECameraBlendSpeedMode> BlendZBasedOn { get; set;}

		[RED("blendZHeightMaxDif")] 		public CFloat BlendZHeightMaxDif { get; set;}

		[RED("blendZDistToForceStart")] 		public CFloat BlendZDistToForceStart { get; set;}

		[RED("blendZDistToForceEnd")] 		public CFloat BlendZDistToForceEnd { get; set;}

		[RED("blendZDistToForceMaxCur")] 		public CFloat BlendZDistToForceMaxCur { get; set;}

		[RED("blendZSpeedTimeMin")] 		public CFloat BlendZSpeedTimeMin { get; set;}

		[RED("blendZSpeedTimeTotal")] 		public CFloat BlendZSpeedTimeTotal { get; set;}

		[RED("blendZSpeedTimeCur")] 		public CFloat BlendZSpeedTimeCur { get; set;}

		[RED("addOffset")] 		public CBool AddOffset { get; set;}

		[RED("verticalDownOffsetMax")] 		public CFloat VerticalDownOffsetMax { get; set;}

		[RED("verticalDownTimeMax")] 		public CFloat VerticalDownTimeMax { get; set;}

		[RED("verticalDownTimeMin")] 		public CFloat VerticalDownTimeMin { get; set;}

		[RED("isInInterior")] 		public CBool IsInInterior { get; set;}

		[RED("blendZInteriorTimeToFall")] 		public CFloat BlendZInteriorTimeToFall { get; set;}

		[RED("blendZSpeedInterior")] 		public CFloat BlendZSpeedInterior { get; set;}

		[RED("blendZSpeedInteriorFall")] 		public CFloat BlendZSpeedInteriorFall { get; set;}

		[RED("heightTraceAlwaysAdjust")] 		public CBool HeightTraceAlwaysAdjust { get; set;}

		[RED("heightTraceEnabled")] 		public CBool HeightTraceEnabled { get; set;}

		[RED("heightTraceDownMax")] 		public CFloat HeightTraceDownMax { get; set;}

		[RED("heightTraceTotalAdded")] 		public CFloat HeightTraceTotalAdded { get; set;}

		[RED("heightTraceAccumulated")] 		public CFloat HeightTraceAccumulated { get; set;}

		[RED("heightTraceMax")] 		public CFloat HeightTraceMax { get; set;}

		[RED("heightTraceTotal")] 		public CFloat HeightTraceTotal { get; set;}

		[RED("heightTraceSpeed")] 		public CFloat HeightTraceSpeed { get; set;}

		[RED("heightTraceSpeedDownMin")] 		public CFloat HeightTraceSpeedDownMin { get; set;}

		[RED("heightTraceSpeedDownMax")] 		public CFloat HeightTraceSpeedDownMax { get; set;}

		[RED("heightTraceCollFlags", 2,0)] 		public CArray<CName> HeightTraceCollFlags { get; set;}

		[RED("heightTraceCollFlagsInit")] 		public CBool HeightTraceCollFlagsInit { get; set;}

		[RED("heightTraceDown")] 		public CBool HeightTraceDown { get; set;}

		[RED("heightTraceDownTimeMin")] 		public CFloat HeightTraceDownTimeMin { get; set;}

		[RED("heightTraceDownTimeMax")] 		public CFloat HeightTraceDownTimeMax { get; set;}

		[RED("traceForwardExtraOffset")] 		public CFloat TraceForwardExtraOffset { get; set;}

		[RED("heightTraceAdjusting")] 		public CBool HeightTraceAdjusting { get; set;}

		[RED("heightAdjustingTime")] 		public CFloat HeightAdjustingTime { get; set;}

		[RED("boneFollowName")] 		public CName BoneFollowName { get; set;}

		[RED("boneFollow")] 		public CInt32 BoneFollow { get; set;}

		[RED("startFollowBoneTime")] 		public CFloat StartFollowBoneTime { get; set;}

		[RED("followBoneOnFall")] 		public CBool FollowBoneOnFall { get; set;}

		[RED("falling")] 		public CBool Falling { get; set;}

		[RED("forceOnGround")] 		public CBool ForceOnGround { get; set;}

		[RED("debugLog")] 		public CBool DebugLog { get; set;}

		[RED("zeroVector")] 		public Vector ZeroVector { get; set;}

		public CCameraPivotPositionControllerJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraPivotPositionControllerJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}