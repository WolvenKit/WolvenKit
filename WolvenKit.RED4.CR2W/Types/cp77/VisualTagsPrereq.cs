using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VisualTagsPrereq : gameIScriptablePrereq
	{
		private CArray<CName> _allowedTags;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("allowedTags")] 
		public CArray<CName> AllowedTags
		{
			get
			{
				if (_allowedTags == null)
				{
					_allowedTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "allowedTags", cr2w, this);
				}
				return _allowedTags;
			}
			set
			{
				if (_allowedTags == value)
				{
					return;
				}
				_allowedTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public VisualTagsPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
