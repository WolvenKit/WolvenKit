using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MediaDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CInt32 _previousStation;
		private CString _activeChannelName;
		private CBool _dataInitialized;
		private CInt32 _amountOfStations;
		private CInt32 _activeStation;

		[Ordinal(104)] 
		[RED("previousStation")] 
		public CInt32 PreviousStation
		{
			get => GetProperty(ref _previousStation);
			set => SetProperty(ref _previousStation, value);
		}

		[Ordinal(105)] 
		[RED("activeChannelName")] 
		public CString ActiveChannelName
		{
			get => GetProperty(ref _activeChannelName);
			set => SetProperty(ref _activeChannelName, value);
		}

		[Ordinal(106)] 
		[RED("dataInitialized")] 
		public CBool DataInitialized
		{
			get => GetProperty(ref _dataInitialized);
			set => SetProperty(ref _dataInitialized, value);
		}

		[Ordinal(107)] 
		[RED("amountOfStations")] 
		public CInt32 AmountOfStations
		{
			get => GetProperty(ref _amountOfStations);
			set => SetProperty(ref _amountOfStations, value);
		}

		[Ordinal(108)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get => GetProperty(ref _activeStation);
			set => SetProperty(ref _activeStation, value);
		}

		public MediaDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
