using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItem : effectBaseItem
	{
		private CFloat _timeBegin;
		private CFloat _timeDuration;
		private CRUID _ruid;

		[Ordinal(0)] 
		[RED("timeBegin")] 
		public CFloat TimeBegin
		{
			get
			{
				if (_timeBegin == null)
				{
					_timeBegin = (CFloat) CR2WTypeManager.Create("Float", "timeBegin", cr2w, this);
				}
				return _timeBegin;
			}
			set
			{
				if (_timeBegin == value)
				{
					return;
				}
				_timeBegin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeDuration")] 
		public CFloat TimeDuration
		{
			get
			{
				if (_timeDuration == null)
				{
					_timeDuration = (CFloat) CR2WTypeManager.Create("Float", "timeDuration", cr2w, this);
				}
				return _timeDuration;
			}
			set
			{
				if (_timeDuration == value)
				{
					return;
				}
				_timeDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get
			{
				if (_ruid == null)
				{
					_ruid = (CRUID) CR2WTypeManager.Create("CRUID", "ruid", cr2w, this);
				}
				return _ruid;
			}
			set
			{
				if (_ruid == value)
				{
					return;
				}
				_ruid = value;
				PropertySet(this);
			}
		}

		public effectTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
