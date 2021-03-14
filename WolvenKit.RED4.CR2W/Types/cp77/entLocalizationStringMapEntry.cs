using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLocalizationStringMapEntry : CVariable
	{
		private CName _key;
		private LocalizationString _string;

		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get
			{
				if (_key == null)
				{
					_key = (CName) CR2WTypeManager.Create("CName", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("string")] 
		public LocalizationString String
		{
			get
			{
				if (_string == null)
				{
					_string = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "string", cr2w, this);
				}
				return _string;
			}
			set
			{
				if (_string == value)
				{
					return;
				}
				_string = value;
				PropertySet(this);
			}
		}

		public entLocalizationStringMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
