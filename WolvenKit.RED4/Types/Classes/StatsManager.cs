using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("playerGodModeModifierData")] 
		public CHandle<gameStatModifierData_Deprecated> PlayerGodModeModifierData
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public StatsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
