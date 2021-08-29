using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_Sound : animAnimEvent
	{
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _params;
		private CArray<CName> _dynamicParams;
		private CName _metadataContext;
		private CName _onlyPlayOn;
		private CName _dontPlayOn;
		private CEnum<animAnimEventGenderAlt> _playerGenderAlt;

		[Ordinal(3)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetProperty(ref _switches);
			set => SetProperty(ref _switches, value);
		}

		[Ordinal(4)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(5)] 
		[RED("dynamicParams")] 
		public CArray<CName> DynamicParams
		{
			get => GetProperty(ref _dynamicParams);
			set => SetProperty(ref _dynamicParams, value);
		}

		[Ordinal(6)] 
		[RED("metadataContext")] 
		public CName MetadataContext
		{
			get => GetProperty(ref _metadataContext);
			set => SetProperty(ref _metadataContext, value);
		}

		[Ordinal(7)] 
		[RED("onlyPlayOn")] 
		public CName OnlyPlayOn
		{
			get => GetProperty(ref _onlyPlayOn);
			set => SetProperty(ref _onlyPlayOn, value);
		}

		[Ordinal(8)] 
		[RED("dontPlayOn")] 
		public CName DontPlayOn
		{
			get => GetProperty(ref _dontPlayOn);
			set => SetProperty(ref _dontPlayOn, value);
		}

		[Ordinal(9)] 
		[RED("playerGenderAlt")] 
		public CEnum<animAnimEventGenderAlt> PlayerGenderAlt
		{
			get => GetProperty(ref _playerGenderAlt);
			set => SetProperty(ref _playerGenderAlt, value);
		}
	}
}
