using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		private inkWidgetReference _ownedFrame;
		private inkWidgetReference _selectedFrame;
		private inkWidgetReference _amountPanel;
		private inkTextWidgetReference _amount;

		[Ordinal(80)] 
		[RED("ownedFrame")] 
		public inkWidgetReference OwnedFrame
		{
			get => GetProperty(ref _ownedFrame);
			set => SetProperty(ref _ownedFrame, value);
		}

		[Ordinal(81)] 
		[RED("selectedFrame")] 
		public inkWidgetReference SelectedFrame
		{
			get => GetProperty(ref _selectedFrame);
			set => SetProperty(ref _selectedFrame, value);
		}

		[Ordinal(82)] 
		[RED("amountPanel")] 
		public inkWidgetReference AmountPanel
		{
			get => GetProperty(ref _amountPanel);
			set => SetProperty(ref _amountPanel, value);
		}

		[Ordinal(83)] 
		[RED("amount")] 
		public inkTextWidgetReference Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public InventoryCyberwareDisplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
