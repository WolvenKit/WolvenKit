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
			get => GetProperty(ref _animsetTags);
			set => SetProperty(ref _animsetTags, value);
		}

		public animAnimsetWithOverridesTagCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
