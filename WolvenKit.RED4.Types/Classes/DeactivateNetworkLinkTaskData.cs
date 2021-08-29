using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeactivateNetworkLinkTaskData : gameScriptTaskData
	{
		private CInt32 _linkIndex;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("linkIndex")] 
		public CInt32 LinkIndex
		{
			get => GetProperty(ref _linkIndex);
			set => SetProperty(ref _linkIndex, value);
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
