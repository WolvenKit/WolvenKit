using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBinkLanguageDescriptor : CVariable
	{
		private raRef<Bink> _bink;
		private CEnum<inkLanguageId> _languageId;

		[Ordinal(0)] 
		[RED("bink")] 
		public raRef<Bink> Bink
		{
			get
			{
				if (_bink == null)
				{
					_bink = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "bink", cr2w, this);
				}
				return _bink;
			}
			set
			{
				if (_bink == value)
				{
					return;
				}
				_bink = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("languageId")] 
		public CEnum<inkLanguageId> LanguageId
		{
			get
			{
				if (_languageId == null)
				{
					_languageId = (CEnum<inkLanguageId>) CR2WTypeManager.Create("inkLanguageId", "languageId", cr2w, this);
				}
				return _languageId;
			}
			set
			{
				if (_languageId == value)
				{
					return;
				}
				_languageId = value;
				PropertySet(this);
			}
		}

		public inkBinkLanguageDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
