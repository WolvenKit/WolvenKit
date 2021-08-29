using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpecificDeathEvents : HighLevelTransition
	{
		private CBool _isDyingEffectPlaying;

		[Ordinal(0)] 
		[RED("isDyingEffectPlaying")] 
		public CBool IsDyingEffectPlaying
		{
			get => GetProperty(ref _isDyingEffectPlaying);
			set => SetProperty(ref _isDyingEffectPlaying, value);
		}
	}
}
