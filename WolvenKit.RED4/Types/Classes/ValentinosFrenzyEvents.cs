using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ValentinosFrenzyEvents : ShootTransition
	{
		[Ordinal(0)] 
		[RED("statMod")] 
		public CHandle<gameStatModifierData_Deprecated> StatMod
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public ValentinosFrenzyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
