using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workPauseClip : workIEntry
	{
		private CFloat _timeMin;
		private CFloat _timeMax;
		private CFloat _blendOutTime;

		[Ordinal(2)] 
		[RED("timeMin")] 
		public CFloat TimeMin
		{
			get
			{
				if (_timeMin == null)
				{
					_timeMin = (CFloat) CR2WTypeManager.Create("Float", "timeMin", cr2w, this);
				}
				return _timeMin;
			}
			set
			{
				if (_timeMin == value)
				{
					return;
				}
				_timeMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeMax")] 
		public CFloat TimeMax
		{
			get
			{
				if (_timeMax == null)
				{
					_timeMax = (CFloat) CR2WTypeManager.Create("Float", "timeMax", cr2w, this);
				}
				return _timeMax;
			}
			set
			{
				if (_timeMax == value)
				{
					return;
				}
				_timeMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get
			{
				if (_blendOutTime == null)
				{
					_blendOutTime = (CFloat) CR2WTypeManager.Create("Float", "blendOutTime", cr2w, this);
				}
				return _blendOutTime;
			}
			set
			{
				if (_blendOutTime == value)
				{
					return;
				}
				_blendOutTime = value;
				PropertySet(this);
			}
		}

		public workPauseClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
