using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_GameplayVo : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("voContext")] 
		public CName VoContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimEvent_GameplayVo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
