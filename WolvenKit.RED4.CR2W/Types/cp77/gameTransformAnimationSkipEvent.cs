using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationSkipEvent : gameTransformAnimationEvent
	{
		private CFloat _time;
		private CBool _skipToEnd;
		private CBool _forcePlay;

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get
			{
				if (_skipToEnd == null)
				{
					_skipToEnd = (CBool) CR2WTypeManager.Create("Bool", "skipToEnd", cr2w, this);
				}
				return _skipToEnd;
			}
			set
			{
				if (_skipToEnd == value)
				{
					return;
				}
				_skipToEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("forcePlay")] 
		public CBool ForcePlay
		{
			get
			{
				if (_forcePlay == null)
				{
					_forcePlay = (CBool) CR2WTypeManager.Create("Bool", "forcePlay", cr2w, this);
				}
				return _forcePlay;
			}
			set
			{
				if (_forcePlay == value)
				{
					return;
				}
				_forcePlay = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimationSkipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
