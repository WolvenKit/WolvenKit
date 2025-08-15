using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelamainTaxiComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CUInt32 State
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public DelamainTaxiComponentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
