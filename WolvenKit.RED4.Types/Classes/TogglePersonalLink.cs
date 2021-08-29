using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TogglePersonalLink : ActionBool
	{
		private CEnum<EPersonalLinkConnectionStatus> _cachedStatus;
		private CBool _shouldSkipMiniGame;

		[Ordinal(25)] 
		[RED("cachedStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> CachedStatus
		{
			get => GetProperty(ref _cachedStatus);
			set => SetProperty(ref _cachedStatus, value);
		}

		[Ordinal(26)] 
		[RED("shouldSkipMiniGame")] 
		public CBool ShouldSkipMiniGame
		{
			get => GetProperty(ref _shouldSkipMiniGame);
			set => SetProperty(ref _shouldSkipMiniGame, value);
		}
	}
}
