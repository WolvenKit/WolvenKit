using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_WeightedQsTransform : ISerializable
	{
		[Ordinal(0)] 
		[RED("channel")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> Channel
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNodeSourceChannel_WeightedQsTransform()
		{
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
