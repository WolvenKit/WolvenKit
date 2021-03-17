using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneWaveformGameController : gameuiWidgetGameController
	{
		private CFloat _measurementsIntreval;
		private CInt32 _measurementsCount;
		private CName _barItemName;
		private wCHandle<inkCompoundWidget> _root;
		private CArray<wCHandle<inkWidget>> _bars;
		private CArray<wCHandle<inkWidget>> _traces;
		private Vector2 _cachedRootSize;
		private CFloat _maxValue;
		private CFloat _barsPadding;
		private Vector2 _barSize;

		[Ordinal(2)] 
		[RED("measurementsIntreval")] 
		public CFloat MeasurementsIntreval
		{
			get => GetProperty(ref _measurementsIntreval);
			set => SetProperty(ref _measurementsIntreval, value);
		}

		[Ordinal(3)] 
		[RED("measurementsCount")] 
		public CInt32 MeasurementsCount
		{
			get => GetProperty(ref _measurementsCount);
			set => SetProperty(ref _measurementsCount, value);
		}

		[Ordinal(4)] 
		[RED("barItemName")] 
		public CName BarItemName
		{
			get => GetProperty(ref _barItemName);
			set => SetProperty(ref _barItemName, value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(6)] 
		[RED("bars")] 
		public CArray<wCHandle<inkWidget>> Bars
		{
			get => GetProperty(ref _bars);
			set => SetProperty(ref _bars, value);
		}

		[Ordinal(7)] 
		[RED("traces")] 
		public CArray<wCHandle<inkWidget>> Traces
		{
			get => GetProperty(ref _traces);
			set => SetProperty(ref _traces, value);
		}

		[Ordinal(8)] 
		[RED("cachedRootSize")] 
		public Vector2 CachedRootSize
		{
			get => GetProperty(ref _cachedRootSize);
			set => SetProperty(ref _cachedRootSize, value);
		}

		[Ordinal(9)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(10)] 
		[RED("barsPadding")] 
		public CFloat BarsPadding
		{
			get => GetProperty(ref _barsPadding);
			set => SetProperty(ref _barsPadding, value);
		}

		[Ordinal(11)] 
		[RED("barSize")] 
		public Vector2 BarSize
		{
			get => GetProperty(ref _barSize);
			set => SetProperty(ref _barSize, value);
		}

		public gameuiPhoneWaveformGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
