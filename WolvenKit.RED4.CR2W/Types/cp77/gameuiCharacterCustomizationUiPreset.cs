using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPreset : CResource
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

		public gameuiCharacterCustomizationUiPreset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
