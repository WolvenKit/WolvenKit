using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeRigMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("matchingRigs")] 
		public CArray<CName> MatchingRigs
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioMeleeRigMapItem()
		{
			MatchingRigs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
