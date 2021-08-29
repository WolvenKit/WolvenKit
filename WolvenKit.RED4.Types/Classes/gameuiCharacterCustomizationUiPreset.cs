using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationUiPreset : CResource
	{
		private CBool _isMaleVO;
		private CArray<gameuiCharacterCustomizationUiPresetValue> _values;

		[Ordinal(1)] 
		[RED("isMaleVO")] 
		public CBool IsMaleVO
		{
			get => GetProperty(ref _isMaleVO);
			set => SetProperty(ref _isMaleVO, value);
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CArray<gameuiCharacterCustomizationUiPresetValue> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}
	}
}
