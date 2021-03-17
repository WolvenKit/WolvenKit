using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftableItemLogicController : inkVirtualCompoundItemController
	{
		private inkCompoundWidgetReference _normalAppearence;
		private wCHandle<InventoryItemDisplayController> _controller;
		private CBool _isSelected;
		private CName _displayToCreate;

		[Ordinal(15)] 
		[RED("normalAppearence")] 
		public inkCompoundWidgetReference NormalAppearence
		{
			get => GetProperty(ref _normalAppearence);
			set => SetProperty(ref _normalAppearence, value);
		}

		[Ordinal(16)] 
		[RED("controller")] 
		public wCHandle<InventoryItemDisplayController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(17)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(18)] 
		[RED("displayToCreate")] 
		public CName DisplayToCreate
		{
			get => GetProperty(ref _displayToCreate);
			set => SetProperty(ref _displayToCreate, value);
		}

		public CraftableItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
