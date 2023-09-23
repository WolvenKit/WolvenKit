using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayPauseActionWidgetController : NextPreviousActionWidgetController
	{
		[Ordinal(36)] 
		[RED("playContainer")] 
		public inkWidgetReference PlayContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayPauseActionWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
