using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
