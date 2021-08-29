using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPerformanceAreaNode : worldTriggerAreaNode
	{
		private CArray<worldQualitySetting> _qualitySettingsArray;
		private CName _disableCrowdUniqueName;
		private CFloat _globalStreamingDistanceScale;

		[Ordinal(7)] 
		[RED("qualitySettingsArray")] 
		public CArray<worldQualitySetting> QualitySettingsArray
		{
			get => GetProperty(ref _qualitySettingsArray);
			set => SetProperty(ref _qualitySettingsArray, value);
		}

		[Ordinal(8)] 
		[RED("disableCrowdUniqueName")] 
		public CName DisableCrowdUniqueName
		{
			get => GetProperty(ref _disableCrowdUniqueName);
			set => SetProperty(ref _disableCrowdUniqueName, value);
		}

		[Ordinal(9)] 
		[RED("globalStreamingDistanceScale")] 
		public CFloat GlobalStreamingDistanceScale
		{
			get => GetProperty(ref _globalStreamingDistanceScale);
			set => SetProperty(ref _globalStreamingDistanceScale, value);
		}
	}
}
