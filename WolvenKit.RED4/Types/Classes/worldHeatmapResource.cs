using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldHeatmapResource : CResource
	{
		[Ordinal(1)] 
		[RED("setup")] 
		public worldHeatmapSetup Setup
		{
			get => GetPropertyValue<worldHeatmapSetup>();
			set => SetPropertyValue<worldHeatmapSetup>(value);
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("layerNames")] 
		public CArray<CString> LayerNames
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(4)] 
		[RED("layers")] 
		public CArray<CResourceAsyncReference<worldHeatmapLayer>> Layers
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<worldHeatmapLayer>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<worldHeatmapLayer>>>(value);
		}

		public worldHeatmapResource()
		{
			Setup = new worldHeatmapSetup { VolumeBox = new Box { Min = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, Max = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue } } };
			LayerNames = new();
			Layers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
