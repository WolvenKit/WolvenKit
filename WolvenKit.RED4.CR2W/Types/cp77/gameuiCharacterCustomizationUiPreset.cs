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
			get
			{
				if (_isMaleVO == null)
				{
					_isMaleVO = (CBool) CR2WTypeManager.Create("Bool", "isMaleVO", cr2w, this);
				}
				return _isMaleVO;
			}
			set
			{
				if (_isMaleVO == value)
				{
					return;
				}
				_isMaleVO = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CArray<gameuiCharacterCustomizationUiPresetValue> Values
		{
			get
			{
				if (_values == null)
				{
					_values = (CArray<gameuiCharacterCustomizationUiPresetValue>) CR2WTypeManager.Create("array:gameuiCharacterCustomizationUiPresetValue", "values", cr2w, this);
				}
				return _values;
			}
			set
			{
				if (_values == value)
				{
					return;
				}
				_values = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationUiPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
