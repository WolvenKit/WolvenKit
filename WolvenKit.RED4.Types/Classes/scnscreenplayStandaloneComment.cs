using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnscreenplayStandaloneComment : RedBaseClass
	{
		private scnscreenplayItemId _itemId;
		private CString _comment;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("comment")] 
		public CString Comment
		{
			get => GetProperty(ref _comment);
			set => SetProperty(ref _comment, value);
		}
	}
}
