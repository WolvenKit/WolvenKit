using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TurnOnPsychoSquadAvCammoEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("go")] 
		public CWeakHandle<gameObject> Go
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public TurnOnPsychoSquadAvCammoEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
