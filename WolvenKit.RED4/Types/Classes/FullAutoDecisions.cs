using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FullAutoDecisions : WeaponTransition
	{
		[Ordinal(3)] 
		[RED("callBackID")] 
		public CHandle<redCallbackObject> CallBackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public FullAutoDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
