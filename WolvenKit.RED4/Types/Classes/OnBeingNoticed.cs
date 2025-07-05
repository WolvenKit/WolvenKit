using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnBeingNoticed : redEvent
	{
		[Ordinal(0)] 
		[RED("objectThatNoticed")] 
		public CWeakHandle<gameObject> ObjectThatNoticed
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public OnBeingNoticed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
