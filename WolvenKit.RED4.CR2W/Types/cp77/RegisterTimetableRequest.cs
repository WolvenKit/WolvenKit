using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterTimetableRequest : gameScriptableSystemRequest
	{
		private PSOwnerData _requesterData;
		private CArray<SDeviceTimetableEntry> _timeTable;
		private CInt32 _lights;

		[Ordinal(0)] 
		[RED("requesterData")] 
		public PSOwnerData RequesterData
		{
			get => GetProperty(ref _requesterData);
			set => SetProperty(ref _requesterData, value);
		}

		[Ordinal(1)] 
		[RED("timeTable")] 
		public CArray<SDeviceTimetableEntry> TimeTable
		{
			get => GetProperty(ref _timeTable);
			set => SetProperty(ref _timeTable, value);
		}

		[Ordinal(2)] 
		[RED("lights")] 
		public CInt32 Lights
		{
			get => GetProperty(ref _lights);
			set => SetProperty(ref _lights, value);
		}

		public RegisterTimetableRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
