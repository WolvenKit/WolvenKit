using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_Sound : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetPropertyValue<CArray<audioAudSwitch>>();
			set => SetPropertyValue<CArray<audioAudSwitch>>(value);
		}

		[Ordinal(4)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get => GetPropertyValue<CArray<audioAudParameter>>();
			set => SetPropertyValue<CArray<audioAudParameter>>(value);
		}

		[Ordinal(5)] 
		[RED("dynamicParams")] 
		public CArray<CName> DynamicParams
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("metadataContext")] 
		public CName MetadataContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("onlyPlayOn")] 
		public CName OnlyPlayOn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("dontPlayOn")] 
		public CName DontPlayOn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("playerGenderAlt")] 
		public CEnum<animAnimEventGenderAlt> PlayerGenderAlt
		{
			get => GetPropertyValue<CEnum<animAnimEventGenderAlt>>();
			set => SetPropertyValue<CEnum<animAnimEventGenderAlt>>(value);
		}

		public animAnimEvent_Sound()
		{
			Switches = new();
			Params = new();
			DynamicParams = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
