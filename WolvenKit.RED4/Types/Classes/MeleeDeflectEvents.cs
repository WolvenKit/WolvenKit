using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeDeflectEvents : MeleeEventsTransition
	{
		[Ordinal(2)] 
		[RED("deflectStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> DeflectStatFlag
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public MeleeDeflectEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
