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
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(1)] 
		[RED("autopilotPos")] 
		public CFloat AutopilotPos
		{
			get => GetProperty(ref _autopilotPos);
			set => SetProperty(ref _autopilotPos, value);
		}

		[Ordinal(2)] 
		[RED("autopilotCurrentSpeed")] 
		public CFloat AutopilotCurrentSpeed
		{
			get => GetProperty(ref _autopilotCurrentSpeed);
			set => SetProperty(ref _autopilotCurrentSpeed, value);
		}

		[Ordinal(3)] 
		[RED("wheelRuntimeData", 4)] 
		public CStatic<vehicleWheelRuntimePSData> WheelRuntimeData
		{
			get => GetProperty(ref _wheelRuntimeData);
			set => SetProperty(ref _wheelRuntimeData, value);
		}

		[Ordinal(4)] 
		[RED("questEnforcedTransform")] 
		public Transform QuestEnforcedTransform
		{
			get => GetProperty(ref _questEnforcedTransform);
			set => SetProperty(ref _questEnforcedTransform, value);
		}

		[Ordinal(5)] 
		[RED("destruction")] 
		public vehicleDestructionPSData Destruction
		{
			get => GetProperty(ref _destruction);
			set => SetProperty(ref _destruction, value);
		}

		[Ordinal(6)] 
		[RED("audio")] 
		public vehicleAudioPSData Audio
		{
			get => GetProperty(ref _audio);
			set => SetProperty(ref _audio, value);
		}

		public vehiclePersistentDataPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
