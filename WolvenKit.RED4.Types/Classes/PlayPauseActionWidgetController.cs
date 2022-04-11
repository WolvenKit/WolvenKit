using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayPauseActionWidgetController : NextPreviousActionWidgetController
	{
		[Ordinal(33)] 
		[RED("playContainer")] 
		public inkWidgetReference PlayContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayPauseActionWidgetController()
		{
			PlayContainer = new();
			IsPlaying = true;
		}
	}
}
