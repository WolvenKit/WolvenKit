using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Disarm : redEvent
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public CWeakHandle<gameObject> Requester
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public Disarm()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
