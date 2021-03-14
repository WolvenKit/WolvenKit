using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagAppearanceGroup : CVariable
	{
		private CArray<CName> _appearances;
		private CArray<CName> _visualTags;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<CName>) CR2WTypeManager.Create("array:CName", "appearances", cr2w, this);
				}
				return _appearances;
			}
			set
			{
				if (_appearances == value)
				{
					return;
				}
				_appearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get
			{
				if (_visualTags == null)
				{
					_visualTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "visualTags", cr2w, this);
				}
				return _visualTags;
			}
			set
			{
				if (_visualTags == value)
				{
					return;
				}
				_visualTags = value;
				PropertySet(this);
			}
		}

		public audioVisualTagAppearanceGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
