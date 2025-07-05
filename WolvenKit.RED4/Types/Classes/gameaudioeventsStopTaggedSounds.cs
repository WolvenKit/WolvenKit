using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsStopTaggedSounds : redEvent
	{
		[Ordinal(0)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsStopTaggedSounds()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
