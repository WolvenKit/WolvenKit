using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivateLinksRequest : gameScriptableSystemRequest
	{
		private CArray<CInt32> _linksIDs;

		[Ordinal(0)] 
		[RED("linksIDs")] 
		public CArray<CInt32> LinksIDs
		{
			get => GetProperty(ref _linksIDs);
			set => SetProperty(ref _linksIDs, value);
		}
	}
}
