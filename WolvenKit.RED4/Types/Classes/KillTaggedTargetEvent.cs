using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KillTaggedTargetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("taggedObject")] 
		public CWeakHandle<gameObject> TaggedObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public KillTaggedTargetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
