using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLatestSaveMetadataInfo : IScriptable
	{
		private CString _locationName;
		private CString _trackedQuest;
		private CEnum<inkLifePath> _lifePath;
		private CDouble _playTime;
		private CDouble _playthroughTime;
		private CUInt64 _initialLoadingScreenID;
		private CString _gameVersion;

		[Ordinal(0)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetProperty(ref _locationName);
			set => SetProperty(ref _locationName, value);
		}

		[Ordinal(1)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(2)] 
		[RED("lifePath")] 
		public CEnum<inkLifePath> LifePath
		{
			get => GetProperty(ref _lifePath);
			set => SetProperty(ref _lifePath, value);
		}

		[Ordinal(3)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get => GetProperty(ref _playTime);
			set => SetProperty(ref _playTime, value);
		}

		[Ordinal(4)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get => GetProperty(ref _playthroughTime);
			set => SetProperty(ref _playthroughTime, value);
		}

		[Ordinal(5)] 
		[RED("initialLoadingScreenID")] 
		public CUInt64 InitialLoadingScreenID
		{
			get => GetProperty(ref _initialLoadingScreenID);
			set => SetProperty(ref _initialLoadingScreenID, value);
		}

		[Ordinal(6)] 
		[RED("gameVersion")] 
		public CString GameVersion
		{
			get => GetProperty(ref _gameVersion);
			set => SetProperty(ref _gameVersion, value);
		}
	}
}
