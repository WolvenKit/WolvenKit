using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsInteractionBaseEvent : redEvent
	{
		private CWeakHandle<gameObject> _hotspot;
		private CWeakHandle<gameObject> _activator;
		private gameinteractionsLayerData _layerData;

		[Ordinal(0)] 
		[RED("hotspot")] 
		public CWeakHandle<gameObject> Hotspot
		{
			get => GetProperty(ref _hotspot);
			set => SetProperty(ref _hotspot, value);
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		[Ordinal(2)] 
		[RED("layerData")] 
		public gameinteractionsLayerData LayerData
		{
			get => GetProperty(ref _layerData);
			set => SetProperty(ref _layerData, value);
		}
	}
}
