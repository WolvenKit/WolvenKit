using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMorphInfo : gameuiCharacterCustomizationInfo
	{
		private CArray<gameuiIndexedMorphName> _morphNames;

		[Ordinal(12)] 
		[RED("morphNames")] 
		public CArray<gameuiIndexedMorphName> MorphNames
		{
			get => GetProperty(ref _morphNames);
			set => SetProperty(ref _morphNames, value);
		}
	}
}
