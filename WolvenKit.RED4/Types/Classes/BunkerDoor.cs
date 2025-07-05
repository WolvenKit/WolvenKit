using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BunkerDoor : Door
	{
		[Ordinal(143)] 
		[RED("loudAnnouncementOpenSoundName")] 
		public CName LoudAnnouncementOpenSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(144)] 
		[RED("halfOpenSoundName")] 
		public CName HalfOpenSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(145)] 
		[RED("glitchingSoundName")] 
		public CName GlitchingSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(146)] 
		[RED("fastOpenSoundName")] 
		public CName FastOpenSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BunkerDoor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
