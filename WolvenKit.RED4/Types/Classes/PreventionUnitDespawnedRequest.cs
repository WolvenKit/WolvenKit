using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionUnitDespawnedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public PreventionUnitDespawnedRequest()
		{
			EntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
