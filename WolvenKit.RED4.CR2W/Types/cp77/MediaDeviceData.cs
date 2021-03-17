using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MediaDeviceData : CVariable
	{
		private CInt32 _initialStation;
		private CInt32 _amountOfStations;
		private CString _activeChannelName;
		private CBool _isInteractive;

		[Ordinal(0)] 
		[RED("initialStation")] 
		public CInt32 InitialStation
		{
			get => GetProperty(ref _initialStation);
			set => SetProperty(ref _initialStation, value);
		}

		[Ordinal(1)] 
		[RED("amountOfStations")] 
		public CInt32 AmountOfStations
		{
			get => GetProperty(ref _amountOfStations);
			set => SetProperty(ref _amountOfStations, value);
		}

		[Ordinal(2)] 
		[RED("activeChannelName")] 
		public CString ActiveChannelName
		{
			get => GetProperty(ref _activeChannelName);
			set => SetProperty(ref _activeChannelName, value);
		}

		[Ordinal(3)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		public MediaDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
