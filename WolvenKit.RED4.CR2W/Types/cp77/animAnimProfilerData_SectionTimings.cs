using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_SectionTimings : CVariable
	{
		private CName _sectionName;
		private CFloat _updateTimeMS;
		private CFloat _sampleTimeMS;

		[Ordinal(0)] 
		[RED("sectionName")] 
		public CName SectionName
		{
			get => GetProperty(ref _sectionName);
			set => SetProperty(ref _sectionName, value);
		}

		[Ordinal(1)] 
		[RED("updateTimeMS")] 
		public CFloat UpdateTimeMS
		{
			get => GetProperty(ref _updateTimeMS);
			set => SetProperty(ref _updateTimeMS, value);
		}

		[Ordinal(2)] 
		[RED("sampleTimeMS")] 
		public CFloat SampleTimeMS
		{
			get => GetProperty(ref _sampleTimeMS);
			set => SetProperty(ref _sampleTimeMS, value);
		}

		public animAnimProfilerData_SectionTimings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
