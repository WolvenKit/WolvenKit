using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpecificDeathEvents : HighLevelTransition
	{
		[Ordinal(0)] 
		[RED("isDyingEffectPlaying")] 
		public CBool IsDyingEffectPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
