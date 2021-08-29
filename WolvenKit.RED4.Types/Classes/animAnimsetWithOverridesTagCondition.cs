using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimsetWithOverridesTagCondition : animIRuntimeCondition
	{
		private redTagList _animsetTags;

		[Ordinal(0)] 
		[RED("animsetTags")] 
		public redTagList AnimsetTags
		{
			get => GetProperty(ref _animsetTags);
			set => SetProperty(ref _animsetTags, value);
		}
	}
}
