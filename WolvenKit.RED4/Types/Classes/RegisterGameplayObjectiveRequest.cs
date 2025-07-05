using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterGameplayObjectiveRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("objectiveData")] 
		public CHandle<GemplayObjectiveData> ObjectiveData
		{
			get => GetPropertyValue<CHandle<GemplayObjectiveData>>();
			set => SetPropertyValue<CHandle<GemplayObjectiveData>>(value);
		}

		public RegisterGameplayObjectiveRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
