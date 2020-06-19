using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraPivotPositionControllerJump : ICustomCameraScriptedPivotPositionController
	{
		[RED("useExactCamera")] 		public CBool UseExactCamera { get; set;}

		[RED("zOffset")] 		public CFloat ZOffset { get; set;}

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

		[RED("blendZDistToForceStart")] 		public CFloat BlendZDistToForceStart { get; set;}

		[RED("blendZDistToForceEnd")] 		public CFloat BlendZDistToForceEnd { get; set;}

		[RED("blendZSpeedTimeMin")] 		public CFloat BlendZSpeedTimeMin { get; set;}

		[RED("blendZSpeedTimeTotal")] 		public CFloat BlendZSpeedTimeTotal { get; set;}

		[RED("addOffset")] 		public CBool AddOffset { get; set;}

		[RED("verticalDownOffsetMax")] 		public CFloat VerticalDownOffsetMax { get; set;}

		[RED("verticalDownTimeMax")] 		public CFloat VerticalDownTimeMax { get; set;}

		[RED("verticalDownTimeMin")] 		public CFloat VerticalDownTimeMin { get; set;}

		[RED("blendZInteriorTimeToFall")] 		public CFloat BlendZInteriorTimeToFall { get; set;}

		[RED("blendZSpeedInterior")] 		public CFloat BlendZSpeedInterior { get; set;}

		[RED("blendZSpeedInteriorFall")] 		public CFloat BlendZSpeedInteriorFall { get; set;}

		[RED("heightTraceAlwaysAdjust")] 		public CBool HeightTraceAlwaysAdjust { get; set;}

		[RED("heightTraceEnabled")] 		public CBool HeightTraceEnabled { get; set;}

		[RED("heightTraceDownMax")] 		public CFloat HeightTraceDownMax { get; set;}

		[RED("heightTraceSpeed")] 		public CFloat HeightTraceSpeed { get; set;}

		[RED("heightTraceSpeedDownMin")] 		public CFloat HeightTraceSpeedDownMin { get; set;}

		[RED("heightTraceSpeedDownMax")] 		public CFloat HeightTraceSpeedDownMax { get; set;}

		[RED("heightTraceDown")] 		public CBool HeightTraceDown { get; set;}

		[RED("heightTraceDownTimeMin")] 		public CFloat HeightTraceDownTimeMin { get; set;}

		[RED("heightTraceDownTimeMax")] 		public CFloat HeightTraceDownTimeMax { get; set;}

		[RED("traceForwardExtraOffset")] 		public CFloat TraceForwardExtraOffset { get; set;}

		[RED("boneFollowName")] 		public CName BoneFollowName { get; set;}

		[RED("startFollowBoneTime")] 		public CFloat StartFollowBoneTime { get; set;}

		[RED("followBoneOnFall")] 		public CBool FollowBoneOnFall { get; set;}

		[RED("forceOnGround")] 		public CBool ForceOnGround { get; set;}

		[RED("debugLog")] 		public CBool DebugLog { get; set;}

		public CCameraPivotPositionControllerJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraPivotPositionControllerJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}