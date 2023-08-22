using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsInteractionBaseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hotspot")] 
		public CWeakHandle<gameObject> Hotspot
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("layerData")] 
		public gameinteractionsLayerData LayerData
		{
			get => GetPropertyValue<gameinteractionsLayerData>();
			set => SetPropertyValue<gameinteractionsLayerData>(value);
		}

		public gameinteractionsInteractionBaseEvent()
		{
			LayerData = new gameinteractionsLayerData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
