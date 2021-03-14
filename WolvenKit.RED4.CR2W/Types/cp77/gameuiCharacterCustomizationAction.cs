using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationAction : CVariable
	{
		private CEnum<gameuiCharacterCustomizationActionType> _type;
		private CString _params;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiCharacterCustomizationActionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameuiCharacterCustomizationActionType>) CR2WTypeManager.Create("gameuiCharacterCustomizationActionType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CString Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CString) CR2WTypeManager.Create("String", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
