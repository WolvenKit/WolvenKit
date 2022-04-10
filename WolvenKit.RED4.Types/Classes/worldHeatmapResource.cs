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
			Setup = new() { VolumeBox = new() { Min = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, Max = new() { X = -340282346638528859811704183484516925440.000000F, Y = -340282346638528859811704183484516925440.000000F, Z = -340282346638528859811704183484516925440.000000F, W = -340282346638528859811704183484516925440.000000F } } };
			LayerNames = new();
			Layers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
