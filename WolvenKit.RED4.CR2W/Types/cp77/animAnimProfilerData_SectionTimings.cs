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
			get
			{
				if (_sectionName == null)
				{
					_sectionName = (CName) CR2WTypeManager.Create("CName", "sectionName", cr2w, this);
				}
				return _sectionName;
			}
			set
			{
				if (_sectionName == value)
				{
					return;
				}
				_sectionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("updateTimeMS")] 
		public CFloat UpdateTimeMS
		{
			get
			{
				if (_updateTimeMS == null)
				{
					_updateTimeMS = (CFloat) CR2WTypeManager.Create("Float", "updateTimeMS", cr2w, this);
				}
				return _updateTimeMS;
			}
			set
			{
				if (_updateTimeMS == value)
				{
					return;
				}
				_updateTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sampleTimeMS")] 
		public CFloat SampleTimeMS
		{
			get
			{
				if (_sampleTimeMS == null)
				{
					_sampleTimeMS = (CFloat) CR2WTypeManager.Create("Float", "sampleTimeMS", cr2w, this);
				}
				return _sampleTimeMS;
			}
			set
			{
				if (_sampleTimeMS == value)
				{
					return;
				}
				_sampleTimeMS = value;
				PropertySet(this);
			}
		}

		public animAnimProfilerData_SectionTimings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
