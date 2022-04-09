using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleTextScrolling : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("scrollingText")] 
		public inkTextWidgetReference ScrollingText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("infiniteloop")] 
		public inkanimPlaybackOptions Infiniteloop
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		public sampleTextScrolling()
		{
			ScrollingText = new();
			Infiniteloop = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
