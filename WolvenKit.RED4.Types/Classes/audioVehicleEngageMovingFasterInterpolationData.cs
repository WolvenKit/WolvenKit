using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleEngageMovingFasterInterpolationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enterCurveType")] 
		public CEnum<audioESoundCurveType> EnterCurveType
		{
			get => GetPropertyValue<CEnum<audioESoundCurveType>>();
			set => SetPropertyValue<CEnum<audioESoundCurveType>>(value);
		}

		[Ordinal(1)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("exitCurveType")] 
		public CEnum<audioESoundCurveType> ExitCurveType
		{
			get => GetPropertyValue<CEnum<audioESoundCurveType>>();
			set => SetPropertyValue<CEnum<audioESoundCurveType>>(value);
		}

		[Ordinal(3)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVehicleEngageMovingFasterInterpolationData()
		{
			EnterCurveType = Enums.audioESoundCurveType.Linear;
			EnterCurveTime = 3.000000F;
			ExitCurveType = Enums.audioESoundCurveType.Linear;
			ExitCurveTime = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
