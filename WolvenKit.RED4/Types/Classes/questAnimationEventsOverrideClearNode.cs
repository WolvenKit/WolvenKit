using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

		public questAnimationEventsOverrideClearNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
