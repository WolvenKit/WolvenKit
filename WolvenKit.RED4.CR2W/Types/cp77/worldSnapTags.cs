using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSnapTags : CVariable
	{
		private CArray<CName> _includeTags;
		private CArray<CName> _excludeTags;

		[Ordinal(0)] 
		[RED("includeTags")] 
		public CArray<CName> IncludeTags
		{
			get
			{
				if (_includeTags == null)
				{
					_includeTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "includeTags", cr2w, this);
				}
				return _includeTags;
			}
			set
			{
				if (_includeTags == value)
				{
					return;
				}
				_includeTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("excludeTags")] 
		public CArray<CName> ExcludeTags
		{
			get
			{
				if (_excludeTags == null)
				{
					_excludeTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "excludeTags", cr2w, this);
				}
				return _excludeTags;
			}
			set
			{
				if (_excludeTags == value)
				{
					return;
				}
				_excludeTags = value;
				PropertySet(this);
			}
		}

		public worldSnapTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
