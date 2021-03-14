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
			get
			{
				if (_cameraProperties == null)
				{
					_cameraProperties = (CameraSetup) CR2WTypeManager.Create("CameraSetup", "cameraProperties", cr2w, this);
				}
				return _cameraProperties;
			}
			set
			{
				if (_cameraProperties == value)
				{
					return;
				}
				_cameraProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(145)] 
		[RED("cameraQuestProperties")] 
		public CameraQuestProperties CameraQuestProperties
		{
			get
			{
				if (_cameraQuestProperties == null)
				{
					_cameraQuestProperties = (CameraQuestProperties) CR2WTypeManager.Create("CameraQuestProperties", "cameraQuestProperties", cr2w, this);
				}
				return _cameraQuestProperties;
			}
			set
			{
				if (_cameraQuestProperties == value)
				{
					return;
				}
				_cameraQuestProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(146)] 
		[RED("cameraState")] 
		public CEnum<ESurveillanceCameraStatus> CameraState
		{
			get
			{
				if (_cameraState == null)
				{
					_cameraState = (CEnum<ESurveillanceCameraStatus>) CR2WTypeManager.Create("ESurveillanceCameraStatus", "cameraState", cr2w, this);
				}
				return _cameraState;
			}
			set
			{
				if (_cameraState == value)
				{
					return;
				}
				_cameraState = value;
				PropertySet(this);
			}
		}

		[Ordinal(147)] 
		[RED("shouldStream")] 
		public CBool ShouldStream
		{
			get
			{
				if (_shouldStream == null)
				{
					_shouldStream = (CBool) CR2WTypeManager.Create("Bool", "shouldStream", cr2w, this);
				}
				return _shouldStream;
			}
			set
			{
				if (_shouldStream == value)
				{
					return;
				}
				_shouldStream = value;
				PropertySet(this);
			}
		}

		[Ordinal(148)] 
		[RED("isDetecting")] 
		public CBool IsDetecting
		{
			get
			{
				if (_isDetecting == null)
				{
					_isDetecting = (CBool) CR2WTypeManager.Create("Bool", "isDetecting", cr2w, this);
				}
				return _isDetecting;
			}
			set
			{
				if (_isDetecting == value)
				{
					return;
				}
				_isDetecting = value;
				PropertySet(this);
			}
		}

		[Ordinal(149)] 
		[RED("feedReceivers")] 
		public CArray<entEntityID> FeedReceivers
		{
			get
			{
				if (_feedReceivers == null)
				{
					_feedReceivers = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "feedReceivers", cr2w, this);
				}
				return _feedReceivers;
			}
			set
			{
				if (_feedReceivers == value)
				{
					return;
				}
				_feedReceivers = value;
				PropertySet(this);
			}
		}

		[Ordinal(150)] 
		[RED("mostRecentRequester")] 
		public entEntityID MostRecentRequester
		{
			get
			{
				if (_mostRecentRequester == null)
				{
					_mostRecentRequester = (entEntityID) CR2WTypeManager.Create("entEntityID", "mostRecentRequester", cr2w, this);
				}
				return _mostRecentRequester;
			}
			set
			{
				if (_mostRecentRequester == value)
				{
					return;
				}
				_mostRecentRequester = value;
				PropertySet(this);
			}
		}

		[Ordinal(151)] 
		[RED("virtualComponentName")] 
		public CName VirtualComponentName
		{
			get
			{
				if (_virtualComponentName == null)
				{
					_virtualComponentName = (CName) CR2WTypeManager.Create("CName", "virtualComponentName", cr2w, this);
				}
				return _virtualComponentName;
			}
			set
			{
				if (_virtualComponentName == value)
				{
					return;
				}
				_virtualComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(152)] 
		[RED("isFeedReplacedWithBink")] 
		public CBool IsFeedReplacedWithBink
		{
			get
			{
				if (_isFeedReplacedWithBink == null)
				{
					_isFeedReplacedWithBink = (CBool) CR2WTypeManager.Create("Bool", "isFeedReplacedWithBink", cr2w, this);
				}
				return _isFeedReplacedWithBink;
			}
			set
			{
				if (_isFeedReplacedWithBink == value)
				{
					return;
				}
				_isFeedReplacedWithBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(153)] 
		[RED("binkVideoPath")] 
		public redResourceReferenceScriptToken BinkVideoPath
		{
			get
			{
				if (_binkVideoPath == null)
				{
					_binkVideoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "binkVideoPath", cr2w, this);
				}
				return _binkVideoPath;
			}
			set
			{
				if (_binkVideoPath == value)
				{
					return;
				}
				_binkVideoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(154)] 
		[RED("shouldRevealEnemies")] 
		public CBool ShouldRevealEnemies
		{
			get
			{
				if (_shouldRevealEnemies == null)
				{
					_shouldRevealEnemies = (CBool) CR2WTypeManager.Create("Bool", "shouldRevealEnemies", cr2w, this);
				}
				return _shouldRevealEnemies;
			}
			set
			{
				if (_shouldRevealEnemies == value)
				{
					return;
				}
				_shouldRevealEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(155)] 
		[RED("cameraSkillChecks")] 
		public CHandle<EngDemoContainer> CameraSkillChecks
		{
			get
			{
				if (_cameraSkillChecks == null)
				{
					_cameraSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "cameraSkillChecks", cr2w, this);
				}
				return _cameraSkillChecks;
			}
			set
			{
				if (_cameraSkillChecks == value)
				{
					return;
				}
				_cameraSkillChecks = value;
				PropertySet(this);
			}
		}

		public SurveillanceCameraControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
