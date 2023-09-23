using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TurnOffPsychoSquadAvCammoEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("go")] 
		public CWeakHandle<gameObject> Go
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public TurnOffPsychoSquadAvCammoEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
