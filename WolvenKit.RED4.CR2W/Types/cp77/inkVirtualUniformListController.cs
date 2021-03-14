using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualUniformListController : inkVirtualCompoundController
	{
		private inkWidgetLibraryReference _itemTemplate;

		[Ordinal(6)] 
		[RED("itemTemplate")] 
		public inkWidgetLibraryReference ItemTemplate
		{
			get
			{
				if (_itemTemplate == null)
				{
					_itemTemplate = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "itemTemplate", cr2w, this);
				}
				return _itemTemplate;
			}
			set
			{
				if (_itemTemplate == value)
				{
					return;
				}
				_itemTemplate = value;
				PropertySet(this);
			}
		}

		public inkVirtualUniformListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
