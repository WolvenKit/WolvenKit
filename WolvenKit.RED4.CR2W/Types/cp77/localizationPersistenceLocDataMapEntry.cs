using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceLocDataMapEntry : CVariable
	{
		private CName _langCode;
		private raRef<JsonResource> _onscreensPath;
		private raRef<JsonResource> _subtitlePath;

		[Ordinal(0)] 
		[RED("langCode")] 
		public CName LangCode
		{
			get
			{
				if (_langCode == null)
				{
					_langCode = (CName) CR2WTypeManager.Create("CName", "langCode", cr2w, this);
				}
				return _langCode;
			}
			set
			{
				if (_langCode == value)
				{
					return;
				}
				_langCode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onscreensPath")] 
		public raRef<JsonResource> OnscreensPath
		{
			get
			{
				if (_onscreensPath == null)
				{
					_onscreensPath = (raRef<JsonResource>) CR2WTypeManager.Create("raRef:JsonResource", "onscreensPath", cr2w, this);
				}
				return _onscreensPath;
			}
			set
			{
				if (_onscreensPath == value)
				{
					return;
				}
				_onscreensPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("subtitlePath")] 
		public raRef<JsonResource> SubtitlePath
		{
			get
			{
				if (_subtitlePath == null)
				{
					_subtitlePath = (raRef<JsonResource>) CR2WTypeManager.Create("raRef:JsonResource", "subtitlePath", cr2w, this);
				}
				return _subtitlePath;
			}
			set
			{
				if (_subtitlePath == value)
				{
					return;
				}
				_subtitlePath = value;
				PropertySet(this);
			}
		}

		public localizationPersistenceLocDataMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
