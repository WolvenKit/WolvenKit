using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLanguage_ConditionType : questISystemConditionType
	{
		private CEnum<questLanguageMode> _mode;
		private CString _languageCode;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questLanguageMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<questLanguageMode>) CR2WTypeManager.Create("questLanguageMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("languageCode")] 
		public CString LanguageCode
		{
			get
			{
				if (_languageCode == null)
				{
					_languageCode = (CString) CR2WTypeManager.Create("String", "languageCode", cr2w, this);
				}
				return _languageCode;
			}
			set
			{
				if (_languageCode == value)
				{
					return;
				}
				_languageCode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public questLanguage_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
