using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTagAppearanceGroup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("voicetags")] 
		public CArray<CName> Voicetags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioVoiceTagAppearanceGroup()
		{
			Appearances = new();
			Voicetags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
