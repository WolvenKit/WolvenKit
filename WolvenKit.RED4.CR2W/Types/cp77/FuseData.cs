using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseData : CVariable
	{
		private PSOwnerData _psOwnerData;
		private CArray<SDeviceTimetableEntry> _timeTable;
		private CInt32 _lights;

		[Ordinal(0)] 
		[RED("psOwnerData")] 
		public PSOwnerData PsOwnerData
		{
			get => GetProperty(ref _psOwnerData);
			set => SetProperty(ref _psOwnerData, value);
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

		public FuseData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
