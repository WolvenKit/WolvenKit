using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeOptionSelectorData : CVariable
	{
		private CInt32 _optionData;
		private CString _optionText;

		[Ordinal(0)] 
		[RED("optionData")] 
		public CInt32 OptionData
		{
			get => GetProperty(ref _optionData);
			set => SetProperty(ref _optionData, value);
		}

		[Ordinal(1)] 
		[RED("optionText")] 
		public CString OptionText
		{
			get => GetProperty(ref _optionText);
			set => SetProperty(ref _optionText, value);
		}

		public gameuiPhotoModeOptionSelectorData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
