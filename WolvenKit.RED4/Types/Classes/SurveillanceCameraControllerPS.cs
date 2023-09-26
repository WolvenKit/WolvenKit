using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SurveillanceCameraControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(150)] 
		[RED("cameraProperties")] 
		public CameraSetup CameraProperties
		{
			get => GetPropertyValue<CameraSetup>();
			set => SetPropertyValue<CameraSetup>(value);
		}

		[Ordinal(151)] 
		[RED("cameraQuestProperties")] 
		public CameraQuestProperties CameraQuestProperties
		{
			get => GetPropertyValue<CameraQuestProperties>();
			set => SetPropertyValue<CameraQuestProperties>(value);
		}

		[Ordinal(152)] 
		[RED("cameraState")] 
		public CEnum<ESurveillanceCameraStatus> CameraState
		{
			get => GetPropertyValue<CEnum<ESurveillanceCameraStatus>>();
			set => SetPropertyValue<CEnum<ESurveillanceCameraStatus>>(value);
		}

		[Ordinal(153)] 
		[RED("shouldStream")] 
		public CBool ShouldStream
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(154)] 
		[RED("isDetecting")] 
		public CBool IsDetecting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(155)] 
		[RED("feedReceivers")] 
		public CArray<entEntityID> FeedReceivers
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(156)] 
		[RED("mostRecentRequester")] 
		public entEntityID MostRecentRequester
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(157)] 
		[RED("virtualComponentName")] 
		public CName VirtualComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(158)] 
		[RED("isFeedReplacedWithBink")] 
		public CBool IsFeedReplacedWithBink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(159)] 
		[RED("binkVideoPath")] 
		public redResourceReferenceScriptToken BinkVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(160)] 
		[RED("shouldRevealEnemies")] 
		public CBool ShouldRevealEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(161)] 
		[RED("cameraSkillChecks")] 
		public CHandle<EngDemoContainer> CameraSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(162)] 
		[RED("overrideTakeOverCameraAngle")] 
		public CBool OverrideTakeOverCameraAngle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(163)] 
		[RED("overrideTakeOverPitch")] 
		public CFloat OverrideTakeOverPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(164)] 
		[RED("overrideTakeOverRotation")] 
		public CFloat OverrideTakeOverRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SurveillanceCameraControllerPS()
		{
			DeviceName = "LocKey#100";
			TweakDBRecord = "Devices.SurveillanceCamera";
			TweakDBDescriptionRecord = 165799279213;
			CanBeInDeviceChain = true;
			LookAtPresetVert = "LookatPreset.CameraVertical";
			LookAtPresetHor = "LookatPreset.CameraHorizontal";
			CameraProperties = new CameraSetup();
			CameraQuestProperties = new CameraQuestProperties { FollowedTargetID = new entEntityID() };
			FeedReceivers = new();
			MostRecentRequester = new entEntityID();
			BinkVideoPath = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
