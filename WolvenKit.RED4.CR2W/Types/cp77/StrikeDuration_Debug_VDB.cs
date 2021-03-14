using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StrikeDuration_Debug_VDB : StrikeDuration_Debug
	{
		private CFloat _uPDATE_DELAY;
		private CFloat _dISPLAY_DURATION;
		private CFloat _timeToNextUpdate;

		[Ordinal(0)] 
		[RED("UPDATE_DELAY")] 
		public CFloat UPDATE_DELAY
		{
			get
			{
				if (_uPDATE_DELAY == null)
				{
					_uPDATE_DELAY = (CFloat) CR2WTypeManager.Create("Float", "UPDATE_DELAY", cr2w, this);
				}
				return _uPDATE_DELAY;
			}
			set
			{
				if (_uPDATE_DELAY == value)
				{
					return;
				}
				_uPDATE_DELAY = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("DISPLAY_DURATION")] 
		public CFloat DISPLAY_DURATION
		{
			get
			{
				if (_dISPLAY_DURATION == null)
				{
					_dISPLAY_DURATION = (CFloat) CR2WTypeManager.Create("Float", "DISPLAY_DURATION", cr2w, this);
				}
				return _dISPLAY_DURATION;
			}
			set
			{
				if (_dISPLAY_DURATION == value)
				{
					return;
				}
				_dISPLAY_DURATION = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get
			{
				if (_timeToNextUpdate == null)
				{
					_timeToNextUpdate = (CFloat) CR2WTypeManager.Create("Float", "timeToNextUpdate", cr2w, this);
				}
				return _timeToNextUpdate;
			}
			set
			{
				if (_timeToNextUpdate == value)
				{
					return;
				}
				_timeToNextUpdate = value;
				PropertySet(this);
			}
		}

		public StrikeDuration_Debug_VDB(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
