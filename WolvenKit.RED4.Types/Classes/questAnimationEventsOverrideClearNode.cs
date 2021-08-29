using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAnimationEventsOverrideClearNode : questIAudioNodeType
	{
		private CBool _resetGlobalOverride;
		private CBool _resetActorsOverride;

		[Ordinal(0)] 
		[RED("resetGlobalOverride")] 
		public CBool ResetGlobalOverride
		{
			get => GetProperty(ref _resetGlobalOverride);
			set => SetProperty(ref _resetGlobalOverride, value);
		}

		[Ordinal(1)] 
		[RED("resetActorsOverride")] 
		public CBool ResetActorsOverride
		{
			get => GetProperty(ref _resetActorsOverride);
			set => SetProperty(ref _resetActorsOverride, value);
		}
	}
}
