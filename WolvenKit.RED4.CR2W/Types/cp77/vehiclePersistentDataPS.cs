using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehiclePersistentDataPS : gameComponentPS
	{
		private CUInt32 _flags;
		private CFloat _autopilotPos;
		private CFloat _autopilotCurrentSpeed;
		private CStatic<vehicleWheelRuntimePSData> _wheelRuntimeData;
		private Transform _questEnforcedTransform;
		private vehicleDestructionPSData _destruction;
		private vehicleAudioPSData _audio;

		[Ordinal(0)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt32) CR2WTypeManager.Create("Uint32", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("autopilotPos")] 
		public CFloat AutopilotPos
		{
			get
			{
				if (_autopilotPos == null)
				{
					_autopilotPos = (CFloat) CR2WTypeManager.Create("Float", "autopilotPos", cr2w, this);
				}
				return _autopilotPos;
			}
			set
			{
				if (_autopilotPos == value)
				{
					return;
				}
				_autopilotPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("autopilotCurrentSpeed")] 
		public CFloat AutopilotCurrentSpeed
		{
			get
			{
				if (_autopilotCurrentSpeed == null)
				{
					_autopilotCurrentSpeed = (CFloat) CR2WTypeManager.Create("Float", "autopilotCurrentSpeed", cr2w, this);
				}
				return _autopilotCurrentSpeed;
			}
			set
			{
				if (_autopilotCurrentSpeed == value)
				{
					return;
				}
				_autopilotCurrentSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("wheelRuntimeData", 4)] 
		public CStatic<vehicleWheelRuntimePSData> WheelRuntimeData
		{
			get
			{
				if (_wheelRuntimeData == null)
				{
					_wheelRuntimeData = (CStatic<vehicleWheelRuntimePSData>) CR2WTypeManager.Create("static:4,vehicleWheelRuntimePSData", "wheelRuntimeData", cr2w, this);
				}
				return _wheelRuntimeData;
			}
			set
			{
				if (_wheelRuntimeData == value)
				{
					return;
				}
				_wheelRuntimeData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("questEnforcedTransform")] 
		public Transform QuestEnforcedTransform
		{
			get
			{
				if (_questEnforcedTransform == null)
				{
					_questEnforcedTransform = (Transform) CR2WTypeManager.Create("Transform", "questEnforcedTransform", cr2w, this);
				}
				return _questEnforcedTransform;
			}
			set
			{
				if (_questEnforcedTransform == value)
				{
					return;
				}
				_questEnforcedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("destruction")] 
		public vehicleDestructionPSData Destruction
		{
			get
			{
				if (_destruction == null)
				{
					_destruction = (vehicleDestructionPSData) CR2WTypeManager.Create("vehicleDestructionPSData", "destruction", cr2w, this);
				}
				return _destruction;
			}
			set
			{
				if (_destruction == value)
				{
					return;
				}
				_destruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("audio")] 
		public vehicleAudioPSData Audio
		{
			get
			{
				if (_audio == null)
				{
					_audio = (vehicleAudioPSData) CR2WTypeManager.Create("vehicleAudioPSData", "audio", cr2w, this);
				}
				return _audio;
			}
			set
			{
				if (_audio == value)
				{
					return;
				}
				_audio = value;
				PropertySet(this);
			}
		}

		public vehiclePersistentDataPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
