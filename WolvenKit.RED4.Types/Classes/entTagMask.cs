using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTagMask : RedBaseClass
	{
		private redTagList _hardTags;
		private redTagList _softTags;
		private redTagList _excludedTags;

		[Ordinal(0)] 
		[RED("hardTags")] 
		public redTagList HardTags
		{
			get => GetProperty(ref _hardTags);
			set => SetProperty(ref _hardTags, value);
		}

		[Ordinal(1)] 
		[RED("softTags")] 
		public redTagList SoftTags
		{
			get => GetProperty(ref _softTags);
			set => SetProperty(ref _softTags, value);
		}

		[Ordinal(2)] 
		[RED("excludedTags")] 
		public redTagList ExcludedTags
		{
			get => GetProperty(ref _excludedTags);
			set => SetProperty(ref _excludedTags, value);
		}
	}
}
