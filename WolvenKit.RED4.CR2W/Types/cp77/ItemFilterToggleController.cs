using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemFilterToggleController : ToggleController
	{
		private inkWidgetReference _newItemDot;
		private CBool _useCategoryFilter;

		[Ordinal(16)] 
		[RED("newItemDot")] 
		public inkWidgetReference NewItemDot
		{
			get
			{
				if (_newItemDot == null)
				{
					_newItemDot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "newItemDot", cr2w, this);
				}
				return _newItemDot;
			}
			set
			{
				if (_newItemDot == value)
				{
					return;
				}
				_newItemDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("useCategoryFilter")] 
		public CBool UseCategoryFilter
		{
			get
			{
				if (_useCategoryFilter == null)
				{
					_useCategoryFilter = (CBool) CR2WTypeManager.Create("Bool", "useCategoryFilter", cr2w, this);
				}
				return _useCategoryFilter;
			}
			set
			{
				if (_useCategoryFilter == value)
				{
					return;
				}
				_useCategoryFilter = value;
				PropertySet(this);
			}
		}

		public ItemFilterToggleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
