using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryResourceWrapper : CVariable
	{
		private raRef<inkWidgetLibraryResource> _library;

		[Ordinal(0)] 
		[RED("library")] 
		public raRef<inkWidgetLibraryResource> Library
		{
			get
			{
				if (_library == null)
				{
					_library = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "library", cr2w, this);
				}
				return _library;
			}
			set
			{
				if (_library == value)
				{
					return;
				}
				_library = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryResourceWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
