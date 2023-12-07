using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedHotkeyItemConsumableController : ChargedHotkeyItemBaseController
	{
		[Ordinal(44)] 
		[RED("c_statPool")] 
		public CEnum<gamedataStatPoolType> C_statPool
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		public ChargedHotkeyItemConsumableController()
		{
			C_statPool = Enums.gamedataStatPoolType.HealingItemsCharges;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
