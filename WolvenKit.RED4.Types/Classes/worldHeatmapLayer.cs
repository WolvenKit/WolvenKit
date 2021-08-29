using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldHeatmapLayer : CResource
	{
		private CUInt32 _minValue;
		private CUInt32 _maxValue;
		private CString _name;
		private CString _units;
		private CBool _invert;

		[Ordinal(1)] 
		[RED("minValue")] 
		public CUInt32 MinValue
		{
			get => GetProperty(ref _minValue);
			set => SetProperty(ref _minValue, value);
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CUInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(4)] 
		[RED("units")] 
		public CString Units
		{
			get => GetProperty(ref _units);
			set => SetProperty(ref _units, value);
		}

		[Ordinal(5)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}
	}
}
