using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BloodswellEffectorColdBloodListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CHandle<BloodswellEffector> Effector
		{
			get => GetPropertyValue<CHandle<BloodswellEffector>>();
			set => SetPropertyValue<CHandle<BloodswellEffector>>(value);
		}

		[Ordinal(1)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public BloodswellEffectorColdBloodListener()
		{
			GameInstance = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
