using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TabRadioGroup : inkRadioGroupController
	{
		private inkCompoundWidgetReference _root;
		private CArray<CWeakHandle<TabButtonController>> _toggles;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(5)] 
		[RED("root")] 
		public inkCompoundWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(6)] 
		[RED("toggles")] 
		public CArray<CWeakHandle<TabButtonController>> Toggles
		{
			get => GetProperty(ref _toggles);
			set => SetProperty(ref _toggles, value);
		}

		[Ordinal(7)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}
	}
}
