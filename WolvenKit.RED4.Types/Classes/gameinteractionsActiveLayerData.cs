using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsActiveLayerData : RedBaseClass
	{
		private CWeakHandle<gameObject> _activator;
		private CName _linkedLayersName;
		private CName _layerName;

		[Ordinal(0)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		[Ordinal(1)] 
		[RED("linkedLayersName")] 
		public CName LinkedLayersName
		{
			get => GetProperty(ref _linkedLayersName);
			set => SetProperty(ref _linkedLayersName, value);
		}

		[Ordinal(2)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetProperty(ref _layerName);
			set => SetProperty(ref _layerName, value);
		}
	}
}
