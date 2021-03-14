using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationPlayEventData : CVariable
	{
		private CFloat _timeScale;
		private CBool _looping;
		private CUInt32 _timesPlayed;

		[Ordinal(0)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get
			{
				if (_timeScale == null)
				{
					_timeScale = (CFloat) CR2WTypeManager.Create("Float", "timeScale", cr2w, this);
				}
				return _timeScale;
			}
			set
			{
				if (_timeScale == value)
				{
					return;
				}
				_timeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("looping")] 
		public CBool Looping
		{
			get
			{
				if (_looping == null)
				{
					_looping = (CBool) CR2WTypeManager.Create("Bool", "looping", cr2w, this);
				}
				return _looping;
			}
			set
			{
				if (_looping == value)
				{
					return;
				}
				_looping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timesPlayed")] 
		public CUInt32 TimesPlayed
		{
			get
			{
				if (_timesPlayed == null)
				{
					_timesPlayed = (CUInt32) CR2WTypeManager.Create("Uint32", "timesPlayed", cr2w, this);
				}
				return _timesPlayed;
			}
			set
			{
				if (_timesPlayed == value)
				{
					return;
				}
				_timesPlayed = value;
				PropertySet(this);
			}
		}

		public STransformAnimationPlayEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
