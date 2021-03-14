using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidResource : CResource
	{
		private CArray<scnActorRid> _actors;
		private CArray<scnCameraRid> _cameras;
		private scnRidSerialNumber _nextSerialNumber;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("actors")] 
		public CArray<scnActorRid> Actors
		{
			get
			{
				if (_actors == null)
				{
					_actors = (CArray<scnActorRid>) CR2WTypeManager.Create("array:scnActorRid", "actors", cr2w, this);
				}
				return _actors;
			}
			set
			{
				if (_actors == value)
				{
					return;
				}
				_actors = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cameras")] 
		public CArray<scnCameraRid> Cameras
		{
			get
			{
				if (_cameras == null)
				{
					_cameras = (CArray<scnCameraRid>) CR2WTypeManager.Create("array:scnCameraRid", "cameras", cr2w, this);
				}
				return _cameras;
			}
			set
			{
				if (_cameras == value)
				{
					return;
				}
				_cameras = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("nextSerialNumber")] 
		public scnRidSerialNumber NextSerialNumber
		{
			get
			{
				if (_nextSerialNumber == null)
				{
					_nextSerialNumber = (scnRidSerialNumber) CR2WTypeManager.Create("scnRidSerialNumber", "nextSerialNumber", cr2w, this);
				}
				return _nextSerialNumber;
			}
			set
			{
				if (_nextSerialNumber == value)
				{
					return;
				}
				_nextSerialNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		public scnRidResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
