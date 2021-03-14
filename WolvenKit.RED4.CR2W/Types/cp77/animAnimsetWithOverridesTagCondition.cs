using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimsetWithOverridesTagCondition : animIRuntimeCondition
	{
		private redTagList _animsetTags;

		[Ordinal(0)] 
		[RED("animsetTags")] 
		public redTagList AnimsetTags
		{
			get
			{
				if (_animsetTags == null)
				{
					_animsetTags = (redTagList) CR2WTypeManager.Create("redTagList", "animsetTags", cr2w, this);
				}
				return _animsetTags;
			}
			set
			{
				if (_animsetTags == value)
				{
					return;
				}
				_animsetTags = value;
				PropertySet(this);
			}
		}

		public animAnimsetWithOverridesTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
