using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldHeatmapResource : CResource
	{
		private worldHeatmapSetup _setup;
		private CString _name;
		private CArray<CString> _layerNames;
		private CArray<CResourceAsyncReference<worldHeatmapLayer>> _layers;

		[Ordinal(1)] 
		[RED("setup")] 
		public worldHeatmapSetup Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(3)] 
		[RED("layerNames")] 
		public CArray<CString> LayerNames
		{
			get => GetProperty(ref _layerNames);
			set => SetProperty(ref _layerNames, value);
		}

		[Ordinal(4)] 
		[RED("layers")] 
		public CArray<CResourceAsyncReference<worldHeatmapLayer>> Layers
		{
			get => GetProperty(ref _layers);
			set => SetProperty(ref _layers, value);
		}
	}
}
