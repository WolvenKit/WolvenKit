using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedInputSetterFloat : entReplicatedInputSetterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entReplicatedInputSetterFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
