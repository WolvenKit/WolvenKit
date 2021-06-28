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
			get => GetProperty(ref _actors);
			set => SetProperty(ref _actors, value);
		}

		[Ordinal(2)] 
		[RED("cameras")] 
		public CArray<scnCameraRid> Cameras
		{
			get => GetProperty(ref _cameras);
			set => SetProperty(ref _cameras, value);
		}

		[Ordinal(3)] 
		[RED("nextSerialNumber")] 
		public scnRidSerialNumber NextSerialNumber
		{
			get => GetProperty(ref _nextSerialNumber);
			set => SetProperty(ref _nextSerialNumber, value);
		}

		[Ordinal(4)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public scnRidResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
