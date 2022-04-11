using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPerformanceAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("qualitySettingsArray")] 
		public CArray<worldQualitySetting> QualitySettingsArray
		{
			get => GetPropertyValue<CArray<worldQualitySetting>>();
			set => SetPropertyValue<CArray<worldQualitySetting>>(value);
		}

		[Ordinal(8)] 
		[RED("disableCrowdUniqueName")] 
		public CName DisableCrowdUniqueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("globalStreamingDistanceScale")] 
		public CFloat GlobalStreamingDistanceScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldPerformanceAreaNode()
		{
			QualitySettingsArray = new();
			GlobalStreamingDistanceScale = 1.000000F;
		}
	}
}
