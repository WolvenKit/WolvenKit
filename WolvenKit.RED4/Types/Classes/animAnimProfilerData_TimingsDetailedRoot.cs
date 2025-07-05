using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimProfilerData_TimingsDetailedRoot : ISerializable
	{
		[Ordinal(0)] 
		[RED("sections")] 
		public CArray<animAnimProfilerData_SectionTimings> Sections
		{
			get => GetPropertyValue<CArray<animAnimProfilerData_SectionTimings>>();
			set => SetPropertyValue<CArray<animAnimProfilerData_SectionTimings>>(value);
		}

		[Ordinal(1)] 
		[RED("timings")] 
		public CArray<animAnimProfilerData_TimingsDetailed> Timings
		{
			get => GetPropertyValue<CArray<animAnimProfilerData_TimingsDetailed>>();
			set => SetPropertyValue<CArray<animAnimProfilerData_TimingsDetailed>>(value);
		}

		public animAnimProfilerData_TimingsDetailedRoot()
		{
			Sections = new();
			Timings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
