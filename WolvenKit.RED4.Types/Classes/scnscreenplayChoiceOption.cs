using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnscreenplayChoiceOption : RedBaseClass
	{
		private scnscreenplayItemId _itemId;
		private scnscreenplayOptionUsage _usage;
		private scnlocLocstringId _locstringId;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public scnscreenplayOptionUsage Usage
		{
			get => GetProperty(ref _usage);
			set => SetProperty(ref _usage, value);
		}

		[Ordinal(2)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get => GetProperty(ref _locstringId);
			set => SetProperty(ref _locstringId, value);
		}
	}
}
