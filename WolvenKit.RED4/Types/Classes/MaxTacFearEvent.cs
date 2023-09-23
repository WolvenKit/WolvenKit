using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MaxTacFearEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("av")] 
		public CWeakHandle<gameObject> Av
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public MaxTacFearEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
