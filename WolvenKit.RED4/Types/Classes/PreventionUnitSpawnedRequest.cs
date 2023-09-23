using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionUnitSpawnedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requestResult")] 
		public gameSpawnRequestResult RequestResult
		{
			get => GetPropertyValue<gameSpawnRequestResult>();
			set => SetPropertyValue<gameSpawnRequestResult>(value);
		}

		public PreventionUnitSpawnedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
