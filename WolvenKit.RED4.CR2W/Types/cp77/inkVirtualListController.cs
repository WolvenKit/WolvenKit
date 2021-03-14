using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualListController : inkVirtualCompoundController
	{
		private CArray<inkWidgetLibraryReference> _itemTemplates;
		private CBool _cycleNavigation;

		[Ordinal(6)] 
		[RED("itemTemplates")] 
		public CArray<inkWidgetLibraryReference> ItemTemplates
		{
			get
			{
				if (_itemTemplates == null)
				{
					_itemTemplates = (CArray<inkWidgetLibraryReference>) CR2WTypeManager.Create("array:inkWidgetLibraryReference", "itemTemplates", cr2w, this);
				}
				return _itemTemplates;
			}
			set
			{
				if (_itemTemplates == value)
				{
					return;
				}
				_itemTemplates = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cycleNavigation")] 
		public CBool CycleNavigation
		{
			get
			{
				if (_cycleNavigation == null)
				{
					_cycleNavigation = (CBool) CR2WTypeManager.Create("Bool", "cycleNavigation", cr2w, this);
				}
				return _cycleNavigation;
			}
			set
			{
				if (_cycleNavigation == value)
				{
					return;
				}
				_cycleNavigation = value;
				PropertySet(this);
			}
		}

		public inkVirtualListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
