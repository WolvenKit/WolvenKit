using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_Finisher : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("finisherScenarios")] 
		public CArray<CHandle<gameIFinisherScenario>> FinisherScenarios
		{
			get => GetPropertyValue<CArray<CHandle<gameIFinisherScenario>>>();
			set => SetPropertyValue<CArray<CHandle<gameIFinisherScenario>>>(value);
		}

		[Ordinal(2)] 
		[RED("alwaysUseEntryAnims")] 
		public CBool AlwaysUseEntryAnims
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("allowCameraMovement")] 
		public CBool AllowCameraMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectExecutor_Finisher()
		{
			FinisherScenarios = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
