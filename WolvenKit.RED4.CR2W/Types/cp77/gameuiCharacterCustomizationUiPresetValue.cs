using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPresetValue : CVariable
	{
		private CName _optionName;
		private CBool _isActive;
		private CUInt32 _value;

		[Ordinal(0)] 
		[RED("optionName")] 
		public CName OptionName
		{
			get => GetProperty(ref _optionName);
			set => SetProperty(ref _optionName, value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gameuiCharacterCustomizationUiPresetValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
