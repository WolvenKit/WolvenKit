using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldQualitySetting : RedBaseClass
	{
		private CEnum<ConfigGraphicsQualityLevel> _qualityLevel;
		private CUInt32 _xEntitiesBudget;

		[Ordinal(0)] 
		[RED("QualityLevel")] 
		public CEnum<ConfigGraphicsQualityLevel> QualityLevel
		{
			get => GetProperty(ref _qualityLevel);
			set => SetProperty(ref _qualityLevel, value);
		}

		[Ordinal(1)] 
		[RED("xEntitiesBudget")] 
		public CUInt32 XEntitiesBudget
		{
			get => GetProperty(ref _xEntitiesBudget);
			set => SetProperty(ref _xEntitiesBudget, value);
		}

		public worldQualitySetting()
		{
			_qualityLevel = new() { Value = Enums.ConfigGraphicsQualityLevel.Console };
			_xEntitiesBudget = 50;
		}
	}
}
