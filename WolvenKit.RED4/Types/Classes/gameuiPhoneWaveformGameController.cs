using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhoneWaveformGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("measurementsIntreval")] 
		public CFloat MeasurementsIntreval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("measurementsCount")] 
		public CInt32 MeasurementsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("barItemName")] 
		public CName BarItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("bars")] 
		public CArray<CWeakHandle<inkWidget>> Bars
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(7)] 
		[RED("traces")] 
		public CArray<CWeakHandle<inkWidget>> Traces
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(8)] 
		[RED("cachedRootSize")] 
		public Vector2 CachedRootSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(9)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("barsPadding")] 
		public CFloat BarsPadding
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("barSize")] 
		public Vector2 BarSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameuiPhoneWaveformGameController()
		{
			MeasurementsIntreval = 0.100000F;
			MeasurementsCount = 10;
			Bars = new();
			Traces = new();
			CachedRootSize = new Vector2();
			MaxValue = 200.000000F;
			BarsPadding = 4.000000F;
			BarSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
