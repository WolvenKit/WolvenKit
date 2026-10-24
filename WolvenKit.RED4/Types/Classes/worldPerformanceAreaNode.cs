using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPerformanceAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] 
		[RED("qualitySettingsArray")] 
		public CArray<worldQualitySetting> QualitySettingsArray
		{
			get => GetPropertyValue<CArray<worldQualitySetting>>();
			set => SetPropertyValue<CArray<worldQualitySetting>>(value);
		}

		[Ordinal(6)] 
		[RED("disableCrowdUniqueName")] 
		public CName DisableCrowdUniqueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("globalStreamingDistanceScale")] 
		public CFloat GlobalStreamingDistanceScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("globalEntityLODDistanceScale")] 
		public CFloat GlobalEntityLODDistanceScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldPerformanceAreaNode()
		{
			Color = new CColor { Blue = 255, Alpha = 128 };
			QualitySettingsArray = new();
			GlobalStreamingDistanceScale = 1.000000F;
			GlobalEntityLODDistanceScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
