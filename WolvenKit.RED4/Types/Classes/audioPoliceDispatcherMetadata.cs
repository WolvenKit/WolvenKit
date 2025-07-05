using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPoliceDispatcherMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("regularInputs")] 
		public CArray<CName> RegularInputs
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("playerChaseStartInputs")] 
		public CArray<CName> PlayerChaseStartInputs
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("playerChaseBackupNeededInputs")] 
		public CArray<CName> PlayerChaseBackupNeededInputs
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("playerChaseEndInputs")] 
		public CArray<CName> PlayerChaseEndInputs
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("dispatcherTimeInterval")] 
		public CFloat DispatcherTimeInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("sceneFilePath")] 
		public CString SceneFilePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public audioPoliceDispatcherMetadata()
		{
			RegularInputs = new();
			PlayerChaseStartInputs = new();
			PlayerChaseBackupNeededInputs = new();
			PlayerChaseEndInputs = new();
			DispatcherTimeInterval = 30.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
