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
		[Ordinal(0)] [RED("("useExactCamera")] 		public CBool UseExactCamera { get; set;}

		[Ordinal(0)] [RED("("originalOffset")] 		public Vector OriginalOffset { get; set;}

		[Ordinal(0)] [RED("("zOffset")] 		public CFloat ZOffset { get; set;}

		[Ordinal(0)] [RED("("originalPosition")] 		public Vector OriginalPosition { get; set;}

		[Ordinal(0)] [RED("("originalHeight")] 		public CFloat OriginalHeight { get; set;}

		[Ordinal(0)] [RED("("blendXYSpeed")] 		public CFloat BlendXYSpeed { get; set;}

		[Ordinal(0)] [RED("("blendXYSpeedWithTime")] 		public CBool BlendXYSpeedWithTime { get; set;}

		[Ordinal(0)] [RED("("blendXYSpeedTimeStart")] 		public CFloat BlendXYSpeedTimeStart { get; set;}

		[Ordinal(0)] [RED("("blendXYSpeedTimeEnd")] 		public CFloat BlendXYSpeedTimeEnd { get; set;}

		[Ordinal(0)] [RED("("blendXYSpeedMin")] 		public CFloat BlendXYSpeedMin { get; set;}

		[Ordinal(0)] [RED("("blendXYSpeedMax")] 		public CFloat BlendXYSpeedMax { get; set;}

		[Ordinal(0)] [RED("("blendZSpeedStart")] 		public CFloat BlendZSpeedStart { get; set;}

		[Ordinal(0)] [RED("("blendZSpeedEnd")] 		public CFloat BlendZSpeedEnd { get; set;}

		[Ordinal(0)] [RED("("blendCurve")] 		public CHandle<CCurve> BlendCurve { get; set;}

		[Ordinal(0)] [RED("("blendZBasedOn")] 		public CEnum<ECameraBlendSpeedMode> BlendZBasedOn { get; set;}

		[Ordinal(0)] [RED("("blendZHeightMaxDif")] 		public CFloat BlendZHeightMaxDif { get; set;}

		[Ordinal(0)] [RED("("blendZDistToForceStart")] 		public CFloat BlendZDistToForceStart { get; set;}

		[Ordinal(0)] [RED("("blendZDistToForceEnd")] 		public CFloat BlendZDistToForceEnd { get; set;}

		[Ordinal(0)] [RED("("blendZDistToForceMaxCur")] 		public CFloat BlendZDistToForceMaxCur { get; set;}

		[Ordinal(0)] [RED("("blendZSpeedTimeMin")] 		public CFloat BlendZSpeedTimeMin { get; set;}

		[Ordinal(0)] [RED("("blendZSpeedTimeTotal")] 		public CFloat BlendZSpeedTimeTotal { get; set;}

		[Ordinal(0)] [RED("("blendZSpeedTimeCur")] 		public CFloat BlendZSpeedTimeCur { get; set;}

		[Ordinal(0)] [RED("("addOffset")] 		public CBool AddOffset { get; set;}

		[Ordinal(0)] [RED("("verticalDownOffsetMax")] 		public CFloat VerticalDownOffsetMax { get; set;}

		[Ordinal(0)] [RED("("verticalDownTimeMax")] 		public CFloat VerticalDownTimeMax { get; set;}

		[Ordinal(0)] [RED("("verticalDownTimeMin")] 		public CFloat VerticalDownTimeMin { get; set;}

		[Ordinal(0)] [RED("("isInInterior")] 		public CBool IsInInterior { get; set;}

		[Ordinal(0)] [RED("("blendZInteriorTimeToFall")] 		public CFloat BlendZInteriorTimeToFall { get; set;}

		[Ordinal(0)] [RED("("blendZSpeedInterior")] 		public CFloat BlendZSpeedInterior { get; set;}

		[Ordinal(0)] [RED("("blendZSpeedInteriorFall")] 		public CFloat BlendZSpeedInteriorFall { get; set;}

		[Ordinal(0)] [RED("("heightTraceAlwaysAdjust")] 		public CBool HeightTraceAlwaysAdjust { get; set;}

		[Ordinal(0)] [RED("("heightTraceEnabled")] 		public CBool HeightTraceEnabled { get; set;}

		[Ordinal(0)] [RED("("heightTraceDownMax")] 		public CFloat HeightTraceDownMax { get; set;}

		[Ordinal(0)] [RED("("heightTraceTotalAdded")] 		public CFloat HeightTraceTotalAdded { get; set;}

		[Ordinal(0)] [RED("("heightTraceAccumulated")] 		public CFloat HeightTraceAccumulated { get; set;}

		[Ordinal(0)] [RED("("heightTraceMax")] 		public CFloat HeightTraceMax { get; set;}

		[Ordinal(0)] [RED("("heightTraceTotal")] 		public CFloat HeightTraceTotal { get; set;}

		[Ordinal(0)] [RED("("heightTraceSpeed")] 		public CFloat HeightTraceSpeed { get; set;}

		[Ordinal(0)] [RED("("heightTraceSpeedDownMin")] 		public CFloat HeightTraceSpeedDownMin { get; set;}

		[Ordinal(0)] [RED("("heightTraceSpeedDownMax")] 		public CFloat HeightTraceSpeedDownMax { get; set;}

		[Ordinal(0)] [RED("("heightTraceCollFlags", 2,0)] 		public CArray<CName> HeightTraceCollFlags { get; set;}

		[Ordinal(0)] [RED("("heightTraceCollFlagsInit")] 		public CBool HeightTraceCollFlagsInit { get; set;}

		[Ordinal(0)] [RED("("heightTraceDown")] 		public CBool HeightTraceDown { get; set;}

		[Ordinal(0)] [RED("("heightTraceDownTimeMin")] 		public CFloat HeightTraceDownTimeMin { get; set;}

		[Ordinal(0)] [RED("("heightTraceDownTimeMax")] 		public CFloat HeightTraceDownTimeMax { get; set;}

		[Ordinal(0)] [RED("("traceForwardExtraOffset")] 		public CFloat TraceForwardExtraOffset { get; set;}

		[Ordinal(0)] [RED("("heightTraceAdjusting")] 		public CBool HeightTraceAdjusting { get; set;}

		[Ordinal(0)] [RED("("heightAdjustingTime")] 		public CFloat HeightAdjustingTime { get; set;}

		[Ordinal(0)] [RED("("boneFollowName")] 		public CName BoneFollowName { get; set;}

		[Ordinal(0)] [RED("("boneFollow")] 		public CInt32 BoneFollow { get; set;}

		[Ordinal(0)] [RED("("startFollowBoneTime")] 		public CFloat StartFollowBoneTime { get; set;}

		[Ordinal(0)] [RED("("followBoneOnFall")] 		public CBool FollowBoneOnFall { get; set;}

		[Ordinal(0)] [RED("("falling")] 		public CBool Falling { get; set;}

		[Ordinal(0)] [RED("("forceOnGround")] 		public CBool ForceOnGround { get; set;}

		[Ordinal(0)] [RED("("debugLog")] 		public CBool DebugLog { get; set;}

		[Ordinal(0)] [RED("("zeroVector")] 		public Vector ZeroVector { get; set;}

		public CCameraPivotPositionControllerJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraPivotPositionControllerJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}