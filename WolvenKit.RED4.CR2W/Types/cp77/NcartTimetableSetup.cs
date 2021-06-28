using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableSetup : CVariable
	{
		private CInt32 _departFrequency;
		private CInt32 _uiUpdateFrequency;

		[Ordinal(0)] 
		[RED("departFrequency")] 
		public CInt32 DepartFrequency
		{
			get => GetProperty(ref _departFrequency);
			set => SetProperty(ref _departFrequency, value);
		}

		[Ordinal(1)] 
		[RED("uiUpdateFrequency")] 
		public CInt32 UiUpdateFrequency
		{
			get => GetProperty(ref _uiUpdateFrequency);
			set => SetProperty(ref _uiUpdateFrequency, value);
		}

		public NcartTimetableSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
