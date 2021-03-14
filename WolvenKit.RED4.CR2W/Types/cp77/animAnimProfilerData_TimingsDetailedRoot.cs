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
			get
			{
				if (_sections == null)
				{
					_sections = (CArray<animAnimProfilerData_SectionTimings>) CR2WTypeManager.Create("array:animAnimProfilerData_SectionTimings", "sections", cr2w, this);
				}
				return _sections;
			}
			set
			{
				if (_sections == value)
				{
					return;
				}
				_sections = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timings")] 
		public CArray<animAnimProfilerData_TimingsDetailed> Timings
		{
			get
			{
				if (_timings == null)
				{
					_timings = (CArray<animAnimProfilerData_TimingsDetailed>) CR2WTypeManager.Create("array:animAnimProfilerData_TimingsDetailed", "timings", cr2w, this);
				}
				return _timings;
			}
			set
			{
				if (_timings == value)
				{
					return;
				}
				_timings = value;
				PropertySet(this);
			}
		}

		public animAnimProfilerData_TimingsDetailedRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
