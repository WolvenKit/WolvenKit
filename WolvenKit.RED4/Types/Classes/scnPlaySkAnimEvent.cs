using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlaySkAnimEvent : scnPlayFPPControlAnimEvent
	{
		[Ordinal(33)] 
		[RED("animName")] 
		public CHandle<scnAnimName> AnimName
		{
			get => GetPropertyValue<CHandle<scnAnimName>>();
			set => SetPropertyValue<CHandle<scnAnimName>>(value);
		}

		[Ordinal(34)] 
		[RED("poseBlendOutWorkspot")] 
		public CHandle<scnEventBlendWorkspotSetupParameters> PoseBlendOutWorkspot
		{
			get => GetPropertyValue<CHandle<scnEventBlendWorkspotSetupParameters>>();
			set => SetPropertyValue<CHandle<scnEventBlendWorkspotSetupParameters>>(value);
		}

		[Ordinal(35)] 
		[RED("rootMotionData")] 
		public scnPlaySkAnimRootMotionData RootMotionData
		{
			get => GetPropertyValue<scnPlaySkAnimRootMotionData>();
			set => SetPropertyValue<scnPlaySkAnimRootMotionData>(value);
		}

		[Ordinal(36)] 
		[RED("playerData")] 
		public scnPlayerAnimData PlayerData
		{
			get => GetPropertyValue<scnPlayerAnimData>();
			set => SetPropertyValue<scnPlayerAnimData>(value);
		}

		public scnPlaySkAnimEvent()
		{
			RootMotionData = new scnPlaySkAnimRootMotionData { OriginMarker = new scnMarker { Type = Enums.scnMarkerType.Global, EntityRef = new gameEntityReference { Names = new() }, IsMounted = true }, OriginOffset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } }, CustomBlendInTime = -1.000000F, CustomBlendInCurve = Enums.scnEasingType.SinusoidalEaseInOut, RemovePitchRollRotation = true, MeshDissolvingEnabled = true, VehicleChangePhysicsState = true, VehicleEnabledPhysicsOnEnd = true, TrajectoryLOD = new() };
			PlayerData = new scnPlayerAnimData { UnmountBodyCarry = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
