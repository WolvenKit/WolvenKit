using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidResource : CResource
	{
		[Ordinal(1)] 
		[RED("actors")] 
		public CArray<scnActorRid> Actors
		{
			get => GetPropertyValue<CArray<scnActorRid>>();
			set => SetPropertyValue<CArray<scnActorRid>>(value);
		}

		[Ordinal(2)] 
		[RED("cameras")] 
		public CArray<scnCameraRid> Cameras
		{
			get => GetPropertyValue<CArray<scnCameraRid>>();
			set => SetPropertyValue<CArray<scnCameraRid>>(value);
		}

		[Ordinal(3)] 
		[RED("nextSerialNumber")] 
		public scnRidSerialNumber NextSerialNumber
		{
			get => GetPropertyValue<scnRidSerialNumber>();
			set => SetPropertyValue<scnRidSerialNumber>(value);
		}

		[Ordinal(4)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnRidResource()
		{
			Actors = new();
			Cameras = new();
			NextSerialNumber = new scnRidSerialNumber();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
