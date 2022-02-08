using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAnimationEventsOverrideClearNode : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("resetGlobalOverride")] 
		public CBool ResetGlobalOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("resetActorsOverride")] 
		public CBool ResetActorsOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
