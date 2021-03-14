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
			get
			{
				if (_measurementsIntreval == null)
				{
					_measurementsIntreval = (CFloat) CR2WTypeManager.Create("Float", "measurementsIntreval", cr2w, this);
				}
				return _measurementsIntreval;
			}
			set
			{
				if (_measurementsIntreval == value)
				{
					return;
				}
				_measurementsIntreval = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("measurementsCount")] 
		public CInt32 MeasurementsCount
		{
			get
			{
				if (_measurementsCount == null)
				{
					_measurementsCount = (CInt32) CR2WTypeManager.Create("Int32", "measurementsCount", cr2w, this);
				}
				return _measurementsCount;
			}
			set
			{
				if (_measurementsCount == value)
				{
					return;
				}
				_measurementsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("barItemName")] 
		public CName BarItemName
		{
			get
			{
				if (_barItemName == null)
				{
					_barItemName = (CName) CR2WTypeManager.Create("CName", "barItemName", cr2w, this);
				}
				return _barItemName;
			}
			set
			{
				if (_barItemName == value)
				{
					return;
				}
				_barItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bars")] 
		public CArray<wCHandle<inkWidget>> Bars
		{
			get
			{
				if (_bars == null)
				{
					_bars = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "bars", cr2w, this);
				}
				return _bars;
			}
			set
			{
				if (_bars == value)
				{
					return;
				}
				_bars = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("traces")] 
		public CArray<wCHandle<inkWidget>> Traces
		{
			get
			{
				if (_traces == null)
				{
					_traces = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "traces", cr2w, this);
				}
				return _traces;
			}
			set
			{
				if (_traces == value)
				{
					return;
				}
				_traces = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("cachedRootSize")] 
		public Vector2 CachedRootSize
		{
			get
			{
				if (_cachedRootSize == null)
				{
					_cachedRootSize = (Vector2) CR2WTypeManager.Create("Vector2", "cachedRootSize", cr2w, this);
				}
				return _cachedRootSize;
			}
			set
			{
				if (_cachedRootSize == value)
				{
					return;
				}
				_cachedRootSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CFloat) CR2WTypeManager.Create("Float", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("barsPadding")] 
		public CFloat BarsPadding
		{
			get
			{
				if (_barsPadding == null)
				{
					_barsPadding = (CFloat) CR2WTypeManager.Create("Float", "barsPadding", cr2w, this);
				}
				return _barsPadding;
			}
			set
			{
				if (_barsPadding == value)
				{
					return;
				}
				_barsPadding = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("barSize")] 
		public Vector2 BarSize
		{
			get
			{
				if (_barSize == null)
				{
					_barSize = (Vector2) CR2WTypeManager.Create("Vector2", "barSize", cr2w, this);
				}
				return _barSize;
			}
			set
			{
				if (_barSize == value)
				{
					return;
				}
				_barSize = value;
				PropertySet(this);
			}
		}

		public gameuiPhoneWaveformGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
