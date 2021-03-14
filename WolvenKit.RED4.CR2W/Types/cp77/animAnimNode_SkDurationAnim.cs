using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkDurationAnim : animAnimNode_SkAnim
	{
		private animFloatLink _duration;

		[Ordinal(30)] 
		[RED("Duration")] 
		public animFloatLink Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "Duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
