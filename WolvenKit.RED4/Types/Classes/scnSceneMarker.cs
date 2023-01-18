using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneMarker : worldIMarker
	{
		[Ordinal(0)] 
		[RED("markers")] 
		public CArray<scnSceneMarkerInternalsAnimEventEntry> Markers
		{
			get => GetPropertyValue<CArray<scnSceneMarkerInternalsAnimEventEntry>>();
			set => SetPropertyValue<CArray<scnSceneMarkerInternalsAnimEventEntry>>(value);
		}

		public scnSceneMarker()
		{
			Markers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
