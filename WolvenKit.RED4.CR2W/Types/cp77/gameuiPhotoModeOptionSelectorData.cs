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
			get
			{
				if (_optionData == null)
				{
					_optionData = (CInt32) CR2WTypeManager.Create("Int32", "optionData", cr2w, this);
				}
				return _optionData;
			}
			set
			{
				if (_optionData == value)
				{
					return;
				}
				_optionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("optionText")] 
		public CString OptionText
		{
			get
			{
				if (_optionText == null)
				{
					_optionText = (CString) CR2WTypeManager.Create("String", "optionText", cr2w, this);
				}
				return _optionText;
			}
			set
			{
				if (_optionText == value)
				{
					return;
				}
				_optionText = value;
				PropertySet(this);
			}
		}

		public gameuiPhotoModeOptionSelectorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
