using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVisionMode_ConditionType : questISystemConditionType
	{
		private CFloat _timeInterval;
		private CEnum<questVisionModeType> _visionModeType;

		[Ordinal(0)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<questVisionModeType> VisionModeType
		{
			get => GetProperty(ref _visionModeType);
			set => SetProperty(ref _visionModeType, value);
		}

		public questVisionMode_ConditionType()
		{
			_timeInterval = 1.000000F;
		}
	}
}
