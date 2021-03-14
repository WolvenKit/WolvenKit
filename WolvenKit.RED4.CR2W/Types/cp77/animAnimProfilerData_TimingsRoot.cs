using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TimingsRoot : ISerializable
	{
		private CArray<animAnimProfilerData_Timings> _timings;

		[Ordinal(0)] 
		[RED("timings")] 
		public CArray<animAnimProfilerData_Timings> Timings
		{
			get
			{
				if (_timings == null)
				{
					_timings = (CArray<animAnimProfilerData_Timings>) CR2WTypeManager.Create("array:animAnimProfilerData_Timings", "timings", cr2w, this);
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

		public animAnimProfilerData_TimingsRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
