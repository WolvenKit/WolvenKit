using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeRigMapItem : audioAudioMetadata
	{
		private CArray<CName> _matchingRigs;

		[Ordinal(1)] 
		[RED("matchingRigs")] 
		public CArray<CName> MatchingRigs
		{
			get => GetProperty(ref _matchingRigs);
			set => SetProperty(ref _matchingRigs, value);
		}
	}
}
