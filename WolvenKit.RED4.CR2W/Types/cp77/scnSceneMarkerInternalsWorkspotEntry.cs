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
			get
			{
				if (_instanceId == null)
				{
					_instanceId = (CRUID) CR2WTypeManager.Create("CRUID", "instanceId", cr2w, this);
				}
				return _instanceId;
			}
			set
			{
				if (_instanceId == value)
				{
					return;
				}
				_instanceId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instanceOrigin")] 
		public Transform InstanceOrigin
		{
			get
			{
				if (_instanceOrigin == null)
				{
					_instanceOrigin = (Transform) CR2WTypeManager.Create("Transform", "instanceOrigin", cr2w, this);
				}
				return _instanceOrigin;
			}
			set
			{
				if (_instanceOrigin == value)
				{
					return;
				}
				_instanceOrigin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<scnSceneMarkerInternalsWorkspotEntrySocket>) CR2WTypeManager.Create("array:scnSceneMarkerInternalsWorkspotEntrySocket", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exits")] 
		public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Exits
		{
			get
			{
				if (_exits == null)
				{
					_exits = (CArray<scnSceneMarkerInternalsWorkspotEntrySocket>) CR2WTypeManager.Create("array:scnSceneMarkerInternalsWorkspotEntrySocket", "exits", cr2w, this);
				}
				return _exits;
			}
			set
			{
				if (_exits == value)
				{
					return;
				}
				_exits = value;
				PropertySet(this);
			}
		}

		public scnSceneMarkerInternalsWorkspotEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
