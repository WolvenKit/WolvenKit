using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationSkipEventData : CVariable
	{
		private CFloat _time;
		private CBool _skipToEnd;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		public STransformAnimationSkipEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
