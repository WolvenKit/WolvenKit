using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleInteriorParameterData : RedBaseClass
	{
		private CEnum<audioESoundCurveType> _enterCurveType;
		private CFloat _enterCurveTime;
		private CFloat _enterDelayTime;
		private CEnum<audioESoundCurveType> _exitCurveType;
		private CFloat _exitCurveTime;
		private CFloat _exitDelayTime;

		[Ordinal(0)] 
		[RED("enterCurveType")] 
		public CEnum<audioESoundCurveType> EnterCurveType
		{
			get => GetProperty(ref _enterCurveType);
			set => SetProperty(ref _enterCurveType, value);
		}

		[Ordinal(1)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get => GetProperty(ref _enterCurveTime);
			set => SetProperty(ref _enterCurveTime, value);
		}

		[Ordinal(2)] 
		[RED("enterDelayTime")] 
		public CFloat EnterDelayTime
		{
			get => GetProperty(ref _enterDelayTime);
			set => SetProperty(ref _enterDelayTime, value);
		}

		[Ordinal(3)] 
		[RED("exitCurveType")] 
		public CEnum<audioESoundCurveType> ExitCurveType
		{
			get => GetProperty(ref _exitCurveType);
			set => SetProperty(ref _exitCurveType, value);
		}

		[Ordinal(4)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get => GetProperty(ref _exitCurveTime);
			set => SetProperty(ref _exitCurveTime, value);
		}

		[Ordinal(5)] 
		[RED("exitDelayTime")] 
		public CFloat ExitDelayTime
		{
			get => GetProperty(ref _exitDelayTime);
			set => SetProperty(ref _exitDelayTime, value);
		}
	}
}
