using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisarmComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("isDisarmingOngoing")] 
		public CBool IsDisarmingOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(7)] 
		[RED("requester")] 
		public CWeakHandle<gameObject> Requester
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public DisarmComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
