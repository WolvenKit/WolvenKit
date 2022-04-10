using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAppearancesGroup : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioAppearancesGroup()
		{
			Appearances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
