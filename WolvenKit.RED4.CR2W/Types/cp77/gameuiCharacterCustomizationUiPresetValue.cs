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
			get
			{
				if (_optionName == null)
				{
					_optionName = (CName) CR2WTypeManager.Create("CName", "optionName", cr2w, this);
				}
				return _optionName;
			}
			set
			{
				if (_optionName == value)
				{
					return;
				}
				_optionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CUInt32) CR2WTypeManager.Create("Uint32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationUiPresetValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
