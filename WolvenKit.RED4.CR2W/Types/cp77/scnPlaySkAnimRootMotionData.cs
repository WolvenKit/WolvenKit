using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimRootMotionData : CVariable
	{
		private CBool _enabled;
		private CEnum<scnRootMotionAnimPlacementMode> _placementMode;
		private scnMarker _originMarker;
		private Transform _originOffset;
		private CFloat _customBlendInTime;
		private CEnum<scnEasingType> _customBlendInCurve;
		private CBool _removePitchRollRotation;
		private CBool _meshDissolvingEnabled;
		private CBool _vehicleChangePhysicsState;
		private CBool _vehicleEnabledPhysicsOnEnd;
		private CArray<scnAnimationMotionSample> _trajectoryLOD;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("placementMode")] 
		public CEnum<scnRootMotionAnimPlacementMode> PlacementMode
		{
			get => GetProperty(ref _placementMode);
			set => SetProperty(ref _placementMode, value);
		}

		[Ordinal(2)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get => GetProperty(ref _originMarker);
			set => SetProperty(ref _originMarker, value);
		}

		[Ordinal(3)] 
		[RED("originOffset")] 
		public Transform OriginOffset
		{
			get => GetProperty(ref _originOffset);
			set => SetProperty(ref _originOffset, value);
		}

		[Ordinal(4)] 
		[RED("customBlendInTime")] 
		public CFloat CustomBlendInTime
		{
			get => GetProperty(ref _customBlendInTime);
			set => SetProperty(ref _customBlendInTime, value);
		}

		[Ordinal(5)] 
		[RED("customBlendInCurve")] 
		public CEnum<scnEasingType> CustomBlendInCurve
		{
			get => GetProperty(ref _customBlendInCurve);
			set => SetProperty(ref _customBlendInCurve, value);
		}

		[Ordinal(6)] 
		[RED("removePitchRollRotation")] 
		public CBool RemovePitchRollRotation
		{
			get => GetProperty(ref _removePitchRollRotation);
			set => SetProperty(ref _removePitchRollRotation, value);
		}

		[Ordinal(7)] 
		[RED("meshDissolvingEnabled")] 
		public CBool MeshDissolvingEnabled
		{
			get => GetProperty(ref _meshDissolvingEnabled);
			set => SetProperty(ref _meshDissolvingEnabled, value);
		}

		[Ordinal(8)] 
		[RED("vehicleChangePhysicsState")] 
		public CBool VehicleChangePhysicsState
		{
			get => GetProperty(ref _vehicleChangePhysicsState);
			set => SetProperty(ref _vehicleChangePhysicsState, value);
		}

		[Ordinal(9)] 
		[RED("vehicleEnabledPhysicsOnEnd")] 
		public CBool VehicleEnabledPhysicsOnEnd
		{
			get => GetProperty(ref _vehicleEnabledPhysicsOnEnd);
			set => SetProperty(ref _vehicleEnabledPhysicsOnEnd, value);
		}

		[Ordinal(10)] 
		[RED("trajectoryLOD")] 
		public CArray<scnAnimationMotionSample> TrajectoryLOD
		{
			get => GetProperty(ref _trajectoryLOD);
			set => SetProperty(ref _trajectoryLOD, value);
		}

		public scnPlaySkAnimRootMotionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
