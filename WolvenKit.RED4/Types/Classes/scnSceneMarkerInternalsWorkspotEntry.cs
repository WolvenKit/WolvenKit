using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneMarkerInternalsWorkspotEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("instanceId")] 
		public CRUID InstanceId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("instanceOrigin")] 
		public Transform InstanceOrigin
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Entries
		{
			get => GetPropertyValue<CArray<scnSceneMarkerInternalsWorkspotEntrySocket>>();
			set => SetPropertyValue<CArray<scnSceneMarkerInternalsWorkspotEntrySocket>>(value);
		}

		[Ordinal(3)] 
		[RED("exits")] 
		public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Exits
		{
			get => GetPropertyValue<CArray<scnSceneMarkerInternalsWorkspotEntrySocket>>();
			set => SetPropertyValue<CArray<scnSceneMarkerInternalsWorkspotEntrySocket>>(value);
		}

		public scnSceneMarkerInternalsWorkspotEntry()
		{
			InstanceOrigin = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			Entries = new();
			Exits = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
