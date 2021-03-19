using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsWorkspotEntry : CVariable
	{
		private CRUID _instanceId;
		private Transform _instanceOrigin;
		private CArray<scnSceneMarkerInternalsWorkspotEntrySocket> _entries;
		private CArray<scnSceneMarkerInternalsWorkspotEntrySocket> _exits;

		[Ordinal(0)] 
		[RED("instanceId")] 
		public CRUID InstanceId
		{
			get => GetProperty(ref _instanceId);
			set => SetProperty(ref _instanceId, value);
		}

		[Ordinal(1)] 
		[RED("instanceOrigin")] 
		public Transform InstanceOrigin
		{
			get => GetProperty(ref _instanceOrigin);
			set => SetProperty(ref _instanceOrigin, value);
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(3)] 
		[RED("exits")] 
		public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Exits
		{
			get => GetProperty(ref _exits);
			set => SetProperty(ref _exits, value);
		}

		public scnSceneMarkerInternalsWorkspotEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
