using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CeaselessLeadAmmoEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("percentToRefund")] 
		public CFloat PercentToRefund
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CeaselessLeadAmmoEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
