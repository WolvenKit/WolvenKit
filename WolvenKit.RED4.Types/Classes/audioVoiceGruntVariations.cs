using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceGruntVariations : RedBaseClass
	{
		private CArray<CName> _cachedVariations;

		[Ordinal(0)] 
		[RED("cachedVariations")] 
		public CArray<CName> CachedVariations
		{
			get => GetProperty(ref _cachedVariations);
			set => SetProperty(ref _cachedVariations, value);
		}
	}
}
