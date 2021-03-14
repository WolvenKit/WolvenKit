using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCensorshipInfo : CVariable
	{
		private CEnum<CensorshipFlags> _censorFlag;
		private CEnum<gameuiCharacterCustomizationActionType> _censorFlagAction;

		[Ordinal(0)] 
		[RED("censorFlag")] 
		public CEnum<CensorshipFlags> CensorFlag
		{
			get
			{
				if (_censorFlag == null)
				{
					_censorFlag = (CEnum<CensorshipFlags>) CR2WTypeManager.Create("CensorshipFlags", "censorFlag", cr2w, this);
				}
				return _censorFlag;
			}
			set
			{
				if (_censorFlag == value)
				{
					return;
				}
				_censorFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("censorFlagAction")] 
		public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction
		{
			get
			{
				if (_censorFlagAction == null)
				{
					_censorFlagAction = (CEnum<gameuiCharacterCustomizationActionType>) CR2WTypeManager.Create("gameuiCharacterCustomizationActionType", "censorFlagAction", cr2w, this);
				}
				return _censorFlagAction;
			}
			set
			{
				if (_censorFlagAction == value)
				{
					return;
				}
				_censorFlagAction = value;
				PropertySet(this);
			}
		}

		public gameuiCensorshipInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
