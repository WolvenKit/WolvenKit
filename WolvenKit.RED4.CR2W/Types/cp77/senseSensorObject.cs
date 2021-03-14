using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSensorObject : ISerializable
	{
		private TweakDBID _presetID;
		private CFloat _detectionFactor;
		private CFloat _detectionDropFactor;
		private CFloat _detectionCoolDownTime;
		private CFloat _detectionPartCoolDownTime;
		private CBool _hearingEnabled;
		private CEnum<gamedataSenseObjectType> _sensorObjectType;

		[Ordinal(0)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get
			{
				if (_presetID == null)
				{
					_presetID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "presetID", cr2w, this);
				}
				return _presetID;
			}
			set
			{
				if (_presetID == value)
				{
					return;
				}
				_presetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("detectionFactor")] 
		public CFloat DetectionFactor
		{
			get
			{
				if (_detectionFactor == null)
				{
					_detectionFactor = (CFloat) CR2WTypeManager.Create("Float", "detectionFactor", cr2w, this);
				}
				return _detectionFactor;
			}
			set
			{
				if (_detectionFactor == value)
				{
					return;
				}
				_detectionFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("detectionDropFactor")] 
		public CFloat DetectionDropFactor
		{
			get
			{
				if (_detectionDropFactor == null)
				{
					_detectionDropFactor = (CFloat) CR2WTypeManager.Create("Float", "detectionDropFactor", cr2w, this);
				}
				return _detectionDropFactor;
			}
			set
			{
				if (_detectionDropFactor == value)
				{
					return;
				}
				_detectionDropFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("detectionCoolDownTime")] 
		public CFloat DetectionCoolDownTime
		{
			get
			{
				if (_detectionCoolDownTime == null)
				{
					_detectionCoolDownTime = (CFloat) CR2WTypeManager.Create("Float", "detectionCoolDownTime", cr2w, this);
				}
				return _detectionCoolDownTime;
			}
			set
			{
				if (_detectionCoolDownTime == value)
				{
					return;
				}
				_detectionCoolDownTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("detectionPartCoolDownTime")] 
		public CFloat DetectionPartCoolDownTime
		{
			get
			{
				if (_detectionPartCoolDownTime == null)
				{
					_detectionPartCoolDownTime = (CFloat) CR2WTypeManager.Create("Float", "detectionPartCoolDownTime", cr2w, this);
				}
				return _detectionPartCoolDownTime;
			}
			set
			{
				if (_detectionPartCoolDownTime == value)
				{
					return;
				}
				_detectionPartCoolDownTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hearingEnabled")] 
		public CBool HearingEnabled
		{
			get
			{
				if (_hearingEnabled == null)
				{
					_hearingEnabled = (CBool) CR2WTypeManager.Create("Bool", "hearingEnabled", cr2w, this);
				}
				return _hearingEnabled;
			}
			set
			{
				if (_hearingEnabled == value)
				{
					return;
				}
				_hearingEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sensorObjectType")] 
		public CEnum<gamedataSenseObjectType> SensorObjectType
		{
			get
			{
				if (_sensorObjectType == null)
				{
					_sensorObjectType = (CEnum<gamedataSenseObjectType>) CR2WTypeManager.Create("gamedataSenseObjectType", "sensorObjectType", cr2w, this);
				}
				return _sensorObjectType;
			}
			set
			{
				if (_sensorObjectType == value)
				{
					return;
				}
				_sensorObjectType = value;
				PropertySet(this);
			}
		}

		public senseSensorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
