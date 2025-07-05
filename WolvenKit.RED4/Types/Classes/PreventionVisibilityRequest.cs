using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionVisibilityRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public CWeakHandle<gameObject> Requester
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("seePlayer")] 
		public CBool SeePlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionVisibilityRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
