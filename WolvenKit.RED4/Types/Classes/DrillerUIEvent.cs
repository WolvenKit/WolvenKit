using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DrillerUIEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("actionChosen")] 
		public gameinteractionsChoice ActionChosen
		{
			get => GetPropertyValue<gameinteractionsChoice>();
			set => SetPropertyValue<gameinteractionsChoice>(value);
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public DrillerUIEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
