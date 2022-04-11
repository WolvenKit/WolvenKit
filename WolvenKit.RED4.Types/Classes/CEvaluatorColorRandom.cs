using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorColorRandom : IEvaluatorColor
	{
		[Ordinal(0)] 
		[RED("min")] 
		public CColor Min
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CColor Max
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("randomPerChannel")] 
		public CBool RandomPerChannel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CEvaluatorColorRandom()
		{
			Min = new();
			Max = new();
			RandomPerChannel = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
