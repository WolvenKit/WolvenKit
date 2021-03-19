using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableControllerPS : ScriptableDeviceComponentPS
	{
		private NcartTimetableSetup _ncartTimetableSetup;
		private CInt32 _currentTimeToDepart;

		[Ordinal(103)] 
		[RED("ncartTimetableSetup")] 
		public NcartTimetableSetup NcartTimetableSetup
		{
			get => GetProperty(ref _ncartTimetableSetup);
			set => SetProperty(ref _ncartTimetableSetup, value);
		}

		[Ordinal(104)] 
		[RED("currentTimeToDepart")] 
		public CInt32 CurrentTimeToDepart
		{
			get => GetProperty(ref _currentTimeToDepart);
			set => SetProperty(ref _currentTimeToDepart, value);
		}

		public NcartTimetableControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
