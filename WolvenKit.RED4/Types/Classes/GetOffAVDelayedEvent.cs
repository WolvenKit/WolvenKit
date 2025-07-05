using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GetOffAVDelayedEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("go")] 
		public CWeakHandle<gameObject> Go
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("checkForHazards")] 
		public CBool CheckForHazards
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GetOffAVDelayedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
