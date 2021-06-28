using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TimingsDetailedRoot : ISerializable
	{
		private CArray<animAnimProfilerData_SectionTimings> _sections;
		private CArray<animAnimProfilerData_TimingsDetailed> _timings;

		[Ordinal(0)] 
		[RED("sections")] 
		public CArray<animAnimProfilerData_SectionTimings> Sections
		{
			get => GetProperty(ref _sections);
			set => SetProperty(ref _sections, value);
		}

		[Ordinal(1)] 
		[RED("timings")] 
		public CArray<animAnimProfilerData_TimingsDetailed> Timings
		{
			get => GetProperty(ref _timings);
			set => SetProperty(ref _timings, value);
		}

		public animAnimProfilerData_TimingsDetailedRoot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
