using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreloadAnimationsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("streamingContextName")] 
		public CName StreamingContextName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("highPriority")] 
		public CBool HighPriority
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreloadAnimationsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
