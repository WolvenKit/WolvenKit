using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraPivotPositionControllerJump : ICustomCameraScriptedPivotPositionController
	{
		[Ordinal(1)] [RED("useExactCamera")] 		public CBool UseExactCamera { get; set;}

		[Ordinal(2)] [RED("originalOffset")] 		public Vector OriginalOffset { get; set;}

		[Ordinal(3)] [RED("zOffset")] 		public CFloat ZOffset { get; set;}

		[Ordinal(4)] [RED("originalPosition")] 		public Vector OriginalPosition { get; set;}

		[Ordinal(5)] [RED("originalHeight")] 		public CFloat OriginalHeight { get; set;}

		[Ordinal(6)] [RED("blendXYSpeed")] 		public CFloat BlendXYSpeed { get; set;}

		[Ordinal(7)] [RED("blendXYSpeedWithTime")] 		public CBool BlendXYSpeedWithTime { get; set;}

		[Ordinal(8)] [RED("blendXYSpeedTimeStart")] 		public CFloat BlendXYSpeedTimeStart { get; set;}

		[Ordinal(9)] [RED("blendXYSpeedTimeEnd")] 		public CFloat BlendXYSpeedTimeEnd { get; set;}

		[Ordinal(10)] [RED("blendXYSpeedMin")] 		public CFloat BlendXYSpeedMin { get; set;}

		[Ordinal(11)] [RED("blendXYSpeedMax")] 		public CFloat BlendXYSpeedMax { get; set;}

		[Ordinal(12)] [RED("blendZSpeedStart")] 		public CFloat BlendZSpeedStart { get; set;}

		[Ordinal(13)] [RED("blendZSpeedEnd")] 		public CFloat BlendZSpeedEnd { get; set;}

		[Ordinal(14)] [RED("blendCurve")] 		public CHandle<CCurve> BlendCurve { get; set;}

		[Ordinal(15)] [RED("blendZBasedOn")] 		public CEnum<ECameraBlendSpeedMode> BlendZBasedOn { get; set;}

		[Ordinal(16)] [RED("blendZHeightMaxDif")] 		public CFloat BlendZHeightMaxDif { get; set;}

		[Ordinal(17)] [RED("blendZDistToForceStart")] 		public CFloat BlendZDistToForceStart { get; set;}

		[Ordinal(18)] [RED("blendZDistToForceEnd")] 		public CFloat BlendZDistToForceEnd { get; set;}

		[Ordinal(19)] [RED("blendZDistToForceMaxCur")] 		public CFloat BlendZDistToForceMaxCur { get; set;}

		[Ordinal(20)] [RED("blendZSpeedTimeMin")] 		public CFloat BlendZSpeedTimeMin { get; set;}

		[Ordinal(21)] [RED("blendZSpeedTimeTotal")] 		public CFloat BlendZSpeedTimeTotal { get; set;}

		[Ordinal(22)] [RED("blendZSpeedTimeCur")] 		public CFloat BlendZSpeedTimeCur { get; set;}

		[Ordinal(23)] [RED("addOffset")] 		public CBool AddOffset { get; set;}

		[Ordinal(24)] [RED("verticalDownOffsetMax")] 		public CFloat VerticalDownOffsetMax { get; set;}

		[Ordinal(25)] [RED("verticalDownTimeMax")] 		public CFloat VerticalDownTimeMax { get; set;}

		[Ordinal(26)] [RED("verticalDownTimeMin")] 		public CFloat VerticalDownTimeMin { get; set;}

		[Ordinal(27)] [RED("isInInterior")] 		public CBool IsInInterior { get; set;}

		[Ordinal(28)] [RED("blendZInteriorTimeToFall")] 		public CFloat BlendZInteriorTimeToFall { get; set;}

		[Ordinal(29)] [RED("blendZSpeedInterior")] 		public CFloat BlendZSpeedInterior { get; set;}

		[Ordinal(30)] [RED("blendZSpeedInteriorFall")] 		public CFloat BlendZSpeedInteriorFall { get; set;}

		[Ordinal(31)] [RED("heightTraceAlwaysAdjust")] 		public CBool HeightTraceAlwaysAdjust { get; set;}

		[Ordinal(32)] [RED("heightTraceEnabled")] 		public CBool HeightTraceEnabled { get; set;}

		[Ordinal(33)] [RED("heightTraceDownMax")] 		public CFloat HeightTraceDownMax { get; set;}

		[Ordinal(34)] [RED("heightTraceTotalAdded")] 		public CFloat HeightTraceTotalAdded { get; set;}

		[Ordinal(35)] [RED("heightTraceAccumulated")] 		public CFloat HeightTraceAccumulated { get; set;}

		[Ordinal(36)] [RED("heightTraceMax")] 		public CFloat HeightTraceMax { get; set;}

		[Ordinal(37)] [RED("heightTraceTotal")] 		public CFloat HeightTraceTotal { get; set;}

		[Ordinal(38)] [RED("heightTraceSpeed")] 		public CFloat HeightTraceSpeed { get; set;}

		[Ordinal(39)] [RED("heightTraceSpeedDownMin")] 		public CFloat HeightTraceSpeedDownMin { get; set;}

		[Ordinal(40)] [RED("heightTraceSpeedDownMax")] 		public CFloat HeightTraceSpeedDownMax { get; set;}

		[Ordinal(41)] [RED("heightTraceCollFlags", 2,0)] 		public CArray<CName> HeightTraceCollFlags { get; set;}

		[Ordinal(42)] [RED("heightTraceCollFlagsInit")] 		public CBool HeightTraceCollFlagsInit { get; set;}

		[Ordinal(43)] [RED("heightTraceDown")] 		public CBool HeightTraceDown { get; set;}

		[Ordinal(44)] [RED("heightTraceDownTimeMin")] 		public CFloat HeightTraceDownTimeMin { get; set;}

		[Ordinal(45)] [RED("heightTraceDownTimeMax")] 		public CFloat HeightTraceDownTimeMax { get; set;}

		[Ordinal(46)] [RED("traceForwardExtraOffset")] 		public CFloat TraceForwardExtraOffset { get; set;}

		[Ordinal(47)] [RED("heightTraceAdjusting")] 		public CBool HeightTraceAdjusting { get; set;}

		[Ordinal(48)] [RED("heightAdjustingTime")] 		public CFloat HeightAdjustingTime { get; set;}

		[Ordinal(49)] [RED("boneFollowName")] 		public CName BoneFollowName { get; set;}

		[Ordinal(50)] [RED("boneFollow")] 		public CInt32 BoneFollow { get; set;}

		[Ordinal(51)] [RED("startFollowBoneTime")] 		public CFloat StartFollowBoneTime { get; set;}

		[Ordinal(52)] [RED("followBoneOnFall")] 		public CBool FollowBoneOnFall { get; set;}

		[Ordinal(53)] [RED("falling")] 		public CBool Falling { get; set;}

		[Ordinal(54)] [RED("forceOnGround")] 		public CBool ForceOnGround { get; set;}

		[Ordinal(55)] [RED("debugLog")] 		public CBool DebugLog { get; set;}

		[Ordinal(56)] [RED("zeroVector")] 		public Vector ZeroVector { get; set;}

		public CCameraPivotPositionControllerJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraPivotPositionControllerJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}