using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectLoopData : CVariable
	{
		private CFloat _startTime;
		private CFloat _endTime;

		[Ordinal(0)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get
			{
				if (_endTime == null)
				{
					_endTime = (CFloat) CR2WTypeManager.Create("Float", "endTime", cr2w, this);
				}
				return _endTime;
			}
			set
			{
				if (_endTime == value)
				{
					return;
				}
				_endTime = value;
				PropertySet(this);
			}
		}

		public effectLoopData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
