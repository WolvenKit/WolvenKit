using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehiclePersistentDataPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("autopilotPos")] 
		public CFloat AutopilotPos
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("autopilotCurrentSpeed")] 
		public CFloat AutopilotCurrentSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("isHackable")] 
		public CBool IsHackable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("wheelRuntimeData", 4)] 
		public CStatic<vehicleWheelRuntimePSData> WheelRuntimeData
		{
			get => GetPropertyValue<CStatic<vehicleWheelRuntimePSData>>();
			set => SetPropertyValue<CStatic<vehicleWheelRuntimePSData>>(value);
		}

		[Ordinal(5)] 
		[RED("questEnforcedTransform")] 
		public Transform QuestEnforcedTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(6)] 
		[RED("destruction")] 
		public vehicleDestructionPSData Destruction
		{
			get => GetPropertyValue<vehicleDestructionPSData>();
			set => SetPropertyValue<vehicleDestructionPSData>(value);
		}

		[Ordinal(7)] 
		[RED("audio")] 
		public vehicleAudioPSData Audio
		{
			get => GetPropertyValue<vehicleAudioPSData>();
			set => SetPropertyValue<vehicleAudioPSData>(value);
		}

		public vehiclePersistentDataPS()
		{
			IsHackable = true;
			WheelRuntimeData = new(4);
			QuestEnforcedTransform = new Transform { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity }, Orientation = new Quaternion { R = 1.000000F } };
			Destruction = new vehicleDestructionPSData { GridValues = new(30), WindshieldPoints = new(), DetachedParts = new() };
			Audio = new vehicleAudioPSData { AcousticIsolationFactor = float.MinValue, GlassAcousticIsolationFactor = float.MinValue, OpenedWindows = new(0) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
