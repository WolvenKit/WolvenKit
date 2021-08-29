using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudParameter : RedBaseClass
	{
		private CName _name;
		private CFloat _value;
		private CEnum<audioESoundCurveType> _enterCurveType;
		private CFloat _enterCurveTime;
		private CEnum<audioESoundCurveType> _exitCurveType;
		private CFloat _exitCurveTime;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("enterCurveType")] 
		public CEnum<audioESoundCurveType> EnterCurveType
		{
			get => GetProperty(ref _enterCurveType);
			set => SetProperty(ref _enterCurveType, value);
		}

		[Ordinal(3)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get => GetProperty(ref _enterCurveTime);
			set => SetProperty(ref _enterCurveTime, value);
		}

		[Ordinal(4)] 
		[RED("exitCurveType")] 
		public CEnum<audioESoundCurveType> ExitCurveType
		{
			get => GetProperty(ref _exitCurveType);
			set => SetProperty(ref _exitCurveType, value);
		}

		[Ordinal(5)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get => GetProperty(ref _exitCurveTime);
			set => SetProperty(ref _exitCurveTime, value);
		}
	}
}
