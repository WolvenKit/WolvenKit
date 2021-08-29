using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformSavedData : RedBaseClass
	{
		private CHandle<gameIMovingPlatformMovement> _movement;
		private CName _destinationName;
		private CInt32 _destinationData;
		private CFloat _time;
		private CFloat _maxTime;
		private CUInt32 _mountedPlayerEntityID;

		[Ordinal(0)] 
		[RED("movement")] 
		public CHandle<gameIMovingPlatformMovement> Movement
		{
			get => GetProperty(ref _movement);
			set => SetProperty(ref _movement, value);
		}

		[Ordinal(1)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get => GetProperty(ref _destinationName);
			set => SetProperty(ref _destinationName, value);
		}

		[Ordinal(2)] 
		[RED("destinationData")] 
		public CInt32 DestinationData
		{
			get => GetProperty(ref _destinationData);
			set => SetProperty(ref _destinationData, value);
		}

		[Ordinal(3)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(4)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetProperty(ref _maxTime);
			set => SetProperty(ref _maxTime, value);
		}

		[Ordinal(5)] 
		[RED("mountedPlayerEntityID")] 
		public CUInt32 MountedPlayerEntityID
		{
			get => GetProperty(ref _mountedPlayerEntityID);
			set => SetProperty(ref _mountedPlayerEntityID, value);
		}
	}
}
