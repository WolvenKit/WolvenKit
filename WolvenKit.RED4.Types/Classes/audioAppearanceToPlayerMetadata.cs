using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAppearanceToPlayerMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("foleyPlayerMetadata")] 
		public CName FoleyPlayerMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<audioFoleyItemPriority> Priority
		{
			get => GetPropertyValue<CEnum<audioFoleyItemPriority>>();
			set => SetPropertyValue<CEnum<audioFoleyItemPriority>>(value);
		}

		public audioAppearanceToPlayerMetadata()
		{
			Appearances = new();
			Priority = Enums.audioFoleyItemPriority.P6;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
