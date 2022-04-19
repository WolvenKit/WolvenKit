using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseSensorObject : ISerializable
	{
		[Ordinal(0)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("detectionFactor")] 
		public CFloat DetectionFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("detectionDropFactor")] 
		public CFloat DetectionDropFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("detectionCoolDownTime")] 
		public CFloat DetectionCoolDownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("detectionPartCoolDownTime")] 
		public CFloat DetectionPartCoolDownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("hearingEnabled")] 
		public CBool HearingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("sensorObjectType")] 
		public CEnum<gamedataSenseObjectType> SensorObjectType
		{
			get => GetPropertyValue<CEnum<gamedataSenseObjectType>>();
			set => SetPropertyValue<CEnum<gamedataSenseObjectType>>(value);
		}

		public senseSensorObject()
		{
			DetectionFactor = 30.000000F;
			DetectionDropFactor = 2.000000F;
			DetectionCoolDownTime = 2.000000F;
			HearingEnabled = true;
			SensorObjectType = Enums.gamedataSenseObjectType.Undefined;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
