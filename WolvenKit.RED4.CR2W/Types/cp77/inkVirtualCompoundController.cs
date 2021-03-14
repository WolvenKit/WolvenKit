using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualCompoundController : inkDiscreteNavigationController
	{
		private inkVirtualCompoundControllerCallback _itemSelected;
		private inkVirtualCompoundControllerCallback _itemActivated;

		[Ordinal(4)] 
		[RED("ItemSelected")] 
		public inkVirtualCompoundControllerCallback ItemSelected
		{
			get
			{
				if (_itemSelected == null)
				{
					_itemSelected = (inkVirtualCompoundControllerCallback) CR2WTypeManager.Create("inkVirtualCompoundControllerCallback", "ItemSelected", cr2w, this);
				}
				return _itemSelected;
			}
			set
			{
				if (_itemSelected == value)
				{
					return;
				}
				_itemSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ItemActivated")] 
		public inkVirtualCompoundControllerCallback ItemActivated
		{
			get
			{
				if (_itemActivated == null)
				{
					_itemActivated = (inkVirtualCompoundControllerCallback) CR2WTypeManager.Create("inkVirtualCompoundControllerCallback", "ItemActivated", cr2w, this);
				}
				return _itemActivated;
			}
			set
			{
				if (_itemActivated == value)
				{
					return;
				}
				_itemActivated = value;
				PropertySet(this);
			}
		}

		public inkVirtualCompoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
