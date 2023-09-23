using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedHotkeyItemConsumableController : ChargedHotkeyItemBaseController
	{
		[Ordinal(42)] 
		[RED("c_statPool")] 
		public CEnum<gamedataStatPoolType> C_statPool
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		public ChargedHotkeyItemConsumableController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
