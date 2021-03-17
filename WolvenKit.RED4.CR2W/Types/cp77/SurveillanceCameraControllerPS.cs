using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCameraControllerPS : SensorDeviceControllerPS
	{
		private CameraSetup _cameraProperties;
		private CameraQuestProperties _cameraQuestProperties;
		private CEnum<ESurveillanceCameraStatus> _cameraState;
		private CBool _shouldStream;
		private CBool _isDetecting;
		private CArray<entEntityID> _feedReceivers;
		private entEntityID _mostRecentRequester;
		private CName _virtualComponentName;
		private CBool _isFeedReplacedWithBink;
		private redResourceReferenceScriptToken _binkVideoPath;
		private CBool _shouldRevealEnemies;
		private CHandle<EngDemoContainer> _cameraSkillChecks;

		[Ordinal(144)] 
		[RED("cameraProperties")] 
		public CameraSetup CameraProperties
		{
			get => GetProperty(ref _cameraProperties);
			set => SetProperty(ref _cameraProperties, value);
		}

		[Ordinal(145)] 
		[RED("cameraQuestProperties")] 
		public CameraQuestProperties CameraQuestProperties
		{
			get => GetProperty(ref _cameraQuestProperties);
			set => SetProperty(ref _cameraQuestProperties, value);
		}

		[Ordinal(146)] 
		[RED("cameraState")] 
		public CEnum<ESurveillanceCameraStatus> CameraState
		{
			get => GetProperty(ref _cameraState);
			set => SetProperty(ref _cameraState, value);
		}

		[Ordinal(147)] 
		[RED("shouldStream")] 
		public CBool ShouldStream
		{
			get => GetProperty(ref _shouldStream);
			set => SetProperty(ref _shouldStream, value);
		}

		[Ordinal(148)] 
		[RED("isDetecting")] 
		public CBool IsDetecting
		{
			get => GetProperty(ref _isDetecting);
			set => SetProperty(ref _isDetecting, value);
		}

		[Ordinal(149)] 
		[RED("feedReceivers")] 
		public CArray<entEntityID> FeedReceivers
		{
			get => GetProperty(ref _feedReceivers);
			set => SetProperty(ref _feedReceivers, value);
		}

		[Ordinal(150)] 
		[RED("mostRecentRequester")] 
		public entEntityID MostRecentRequester
		{
			get => GetProperty(ref _mostRecentRequester);
			set => SetProperty(ref _mostRecentRequester, value);
		}

		[Ordinal(151)] 
		[RED("virtualComponentName")] 
		public CName VirtualComponentName
		{
			get => GetProperty(ref _virtualComponentName);
			set => SetProperty(ref _virtualComponentName, value);
		}

		[Ordinal(152)] 
		[RED("isFeedReplacedWithBink")] 
		public CBool IsFeedReplacedWithBink
		{
			get => GetProperty(ref _isFeedReplacedWithBink);
			set => SetProperty(ref _isFeedReplacedWithBink, value);
		}

		[Ordinal(153)] 
		[RED("binkVideoPath")] 
		public redResourceReferenceScriptToken BinkVideoPath
		{
			get => GetProperty(ref _binkVideoPath);
			set => SetProperty(ref _binkVideoPath, value);
		}

		[Ordinal(154)] 
		[RED("shouldRevealEnemies")] 
		public CBool ShouldRevealEnemies
		{
			get => GetProperty(ref _shouldRevealEnemies);
			set => SetProperty(ref _shouldRevealEnemies, value);
		}

		[Ordinal(155)] 
		[RED("cameraSkillChecks")] 
		public CHandle<EngDemoContainer> CameraSkillChecks
		{
			get => GetProperty(ref _cameraSkillChecks);
			set => SetProperty(ref _cameraSkillChecks, value);
		}

		public SurveillanceCameraControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
