using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPoliceDispatcherMetadata : audioAudioMetadata
	{
		private CArray<CName> _regularInputs;
		private CArray<CName> _playerChaseStartInputs;
		private CArray<CName> _playerChaseBackupNeededInputs;
		private CArray<CName> _playerChaseEndInputs;
		private CFloat _dispatcherTimeInterval;
		private CString _sceneFilePath;

		[Ordinal(1)] 
		[RED("regularInputs")] 
		public CArray<CName> RegularInputs
		{
			get => GetProperty(ref _regularInputs);
			set => SetProperty(ref _regularInputs, value);
		}

		[Ordinal(2)] 
		[RED("playerChaseStartInputs")] 
		public CArray<CName> PlayerChaseStartInputs
		{
			get => GetProperty(ref _playerChaseStartInputs);
			set => SetProperty(ref _playerChaseStartInputs, value);
		}

		[Ordinal(3)] 
		[RED("playerChaseBackupNeededInputs")] 
		public CArray<CName> PlayerChaseBackupNeededInputs
		{
			get => GetProperty(ref _playerChaseBackupNeededInputs);
			set => SetProperty(ref _playerChaseBackupNeededInputs, value);
		}

		[Ordinal(4)] 
		[RED("playerChaseEndInputs")] 
		public CArray<CName> PlayerChaseEndInputs
		{
			get => GetProperty(ref _playerChaseEndInputs);
			set => SetProperty(ref _playerChaseEndInputs, value);
		}

		[Ordinal(5)] 
		[RED("dispatcherTimeInterval")] 
		public CFloat DispatcherTimeInterval
		{
			get => GetProperty(ref _dispatcherTimeInterval);
			set => SetProperty(ref _dispatcherTimeInterval, value);
		}

		[Ordinal(6)] 
		[RED("sceneFilePath")] 
		public CString SceneFilePath
		{
			get => GetProperty(ref _sceneFilePath);
			set => SetProperty(ref _sceneFilePath, value);
		}

		public audioPoliceDispatcherMetadata()
		{
			_dispatcherTimeInterval = 30.000000F;
		}
	}
}
