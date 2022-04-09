using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsPlaySound : redEvent
	{
		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("seekTime")] 
		public CFloat SeekTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("playUnique")] 
		public CBool PlayUnique
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameaudioeventsPlaySound()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
