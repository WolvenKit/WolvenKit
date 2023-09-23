using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedItemsPrereqListener : BaseStatPoolPrereqListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<ChargedItemsPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<ChargedItemsPrereqState>>();
			set => SetPropertyValue<CWeakHandle<ChargedItemsPrereqState>>(value);
		}

		public ChargedItemsPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
