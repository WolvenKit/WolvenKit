using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SurveillanceCameraControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(145)] 
		[RED("cameraProperties")] 
		public CameraSetup CameraProperties
		{
			get => GetPropertyValue<CameraSetup>();
			set => SetPropertyValue<CameraSetup>(value);
		}

		[Ordinal(146)] 
		[RED("cameraQuestProperties")] 
		public CameraQuestProperties CameraQuestProperties
		{
			get => GetPropertyValue<CameraQuestProperties>();
			set => SetPropertyValue<CameraQuestProperties>(value);
		}

		[Ordinal(147)] 
		[RED("cameraState")] 
		public CEnum<ESurveillanceCameraStatus> CameraState
		{
			get => GetPropertyValue<CEnum<ESurveillanceCameraStatus>>();
			set => SetPropertyValue<CEnum<ESurveillanceCameraStatus>>(value);
		}

		[Ordinal(148)] 
		[RED("shouldStream")] 
		public CBool ShouldStream
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(149)] 
		[RED("isDetecting")] 
		public CBool IsDetecting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(150)] 
		[RED("feedReceivers")] 
		public CArray<entEntityID> FeedReceivers
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(151)] 
		[RED("mostRecentRequester")] 
		public entEntityID MostRecentRequester
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(152)] 
		[RED("virtualComponentName")] 
		public CName VirtualComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(153)] 
		[RED("isFeedReplacedWithBink")] 
		public CBool IsFeedReplacedWithBink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(154)] 
		[RED("binkVideoPath")] 
		public redResourceReferenceScriptToken BinkVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(155)] 
		[RED("shouldRevealEnemies")] 
		public CBool ShouldRevealEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(156)] 
		[RED("cameraSkillChecks")] 
		public CHandle<EngDemoContainer> CameraSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		public SurveillanceCameraControllerPS()
		{
			DeviceName = "LocKey#100";
			TweakDBRecord = 112145183848;
			TweakDBDescriptionRecord = 165799279213;
			CanBeInDeviceChain = true;
			LookAtPresetVert = 118588422213;
			LookAtPresetHor = 126989615262;
			CameraProperties = new();
			CameraQuestProperties = new() { FollowedTargetID = new() };
			FeedReceivers = new();
			MostRecentRequester = new();
			BinkVideoPath = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
