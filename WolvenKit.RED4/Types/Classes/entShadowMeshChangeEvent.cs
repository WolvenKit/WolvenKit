using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entShadowMeshChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requestedState")] 
		public CEnum<entAppearanceStatus> RequestedState
		{
			get => GetPropertyValue<CEnum<entAppearanceStatus>>();
			set => SetPropertyValue<CEnum<entAppearanceStatus>>(value);
		}

		public entShadowMeshChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
