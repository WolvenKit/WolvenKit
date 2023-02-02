using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTransformHistoryComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("historyLength")] 
		public CFloat HistoryLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("samplesAmount")] 
		public CUInt32 SamplesAmount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public entTransformHistoryComponent()
		{
			Name = "Component";
			HistoryLength = 30.000000F;
			SamplesAmount = 60;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
