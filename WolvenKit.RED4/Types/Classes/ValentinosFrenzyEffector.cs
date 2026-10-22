using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ValentinosFrenzyEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("countToRefund")] 
		public CInt32 CountToRefund
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("weaponToRefund")] 
		public CName WeaponToRefund
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ValentinosFrenzyEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
