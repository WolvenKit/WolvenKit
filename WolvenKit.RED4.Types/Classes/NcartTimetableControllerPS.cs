using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NcartTimetableControllerPS : ScriptableDeviceComponentPS
	{
		private NcartTimetableSetup _ncartTimetableSetup;
		private CInt32 _currentTimeToDepart;

		[Ordinal(104)] 
		[RED("ncartTimetableSetup")] 
		public NcartTimetableSetup NcartTimetableSetup
		{
			get => GetProperty(ref _ncartTimetableSetup);
			set => SetProperty(ref _ncartTimetableSetup, value);
		}

		[Ordinal(105)] 
		[RED("currentTimeToDepart")] 
		public CInt32 CurrentTimeToDepart
		{
			get => GetProperty(ref _currentTimeToDepart);
			set => SetProperty(ref _currentTimeToDepart, value);
		}
	}
}
