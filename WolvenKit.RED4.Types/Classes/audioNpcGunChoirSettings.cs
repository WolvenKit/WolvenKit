using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioNpcGunChoirSettings : audioAudioMetadata
	{
		private CArray<CName> _voices;

		[Ordinal(1)] 
		[RED("voices")] 
		public CArray<CName> Voices
		{
			get => GetProperty(ref _voices);
			set => SetProperty(ref _voices, value);
		}
	}
}
