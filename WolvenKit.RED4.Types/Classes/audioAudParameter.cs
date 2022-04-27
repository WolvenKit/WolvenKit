using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudParameter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("enterCurveType")] 
		public CEnum<audioESoundCurveType> EnterCurveType
		{
			get => GetPropertyValue<CEnum<audioESoundCurveType>>();
			set => SetPropertyValue<CEnum<audioESoundCurveType>>(value);
		}

		[Ordinal(3)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("exitCurveType")] 
		public CEnum<audioESoundCurveType> ExitCurveType
		{
			get => GetPropertyValue<CEnum<audioESoundCurveType>>();
			set => SetPropertyValue<CEnum<audioESoundCurveType>>(value);
		}

		[Ordinal(5)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioAudParameter()
		{
			EnterCurveType = Enums.audioESoundCurveType.Linear;
			EnterCurveTime = 1.000000F;
			ExitCurveType = Enums.audioESoundCurveType.Linear;
			ExitCurveTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
