using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingControllerScheme : inkWidgetLogicController
	{
		private inkWidgetReference _tabRootRef;
		private inkWidgetReference _inputTab;
		private inkWidgetReference _vehiclesTab;
		private inkWidgetReference _braindanceTab;
		private CWeakHandle<TabRadioGroup> _tabRoot;

		[Ordinal(1)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetProperty(ref _tabRootRef);
			set => SetProperty(ref _tabRootRef, value);
		}

		[Ordinal(2)] 
		[RED("inputTab")] 
		public inkWidgetReference InputTab
		{
			get => GetProperty(ref _inputTab);
			set => SetProperty(ref _inputTab, value);
		}

		[Ordinal(3)] 
		[RED("vehiclesTab")] 
		public inkWidgetReference VehiclesTab
		{
			get => GetProperty(ref _vehiclesTab);
			set => SetProperty(ref _vehiclesTab, value);
		}

		[Ordinal(4)] 
		[RED("braindanceTab")] 
		public inkWidgetReference BraindanceTab
		{
			get => GetProperty(ref _braindanceTab);
			set => SetProperty(ref _braindanceTab, value);
		}

		[Ordinal(5)] 
		[RED("tabRoot")] 
		public CWeakHandle<TabRadioGroup> TabRoot
		{
			get => GetProperty(ref _tabRoot);
			set => SetProperty(ref _tabRoot, value);
		}
	}
}
