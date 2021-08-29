using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeactivateLinksRequest : gameScriptableSystemRequest
	{
		private CArray<CInt32> _linksIDs;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("linksIDs")] 
		public CArray<CInt32> LinksIDs
		{
			get => GetProperty(ref _linksIDs);
			set => SetProperty(ref _linksIDs, value);
		}

		[Ordinal(1)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}
	}
}
