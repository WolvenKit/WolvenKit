using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverheatDecisions : WeaponTransition
	{
		[Ordinal(3)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public OverheatDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
