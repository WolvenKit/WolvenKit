using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldMapTooltipContainer : inkWidgetLogicController
	{
		private inkWidgetReference _defaultTooltip;
		private inkWidgetReference _policeTooltip;
		private inkWidgetReference _districtTooltip;
		private CWeakHandle<WorldMapTooltipBaseController> _defaultTooltipController;
		private CWeakHandle<WorldMapTooltipBaseController> _policeTooltipController;
		private CWeakHandle<WorldMapTooltipBaseController> _districtTooltipController;
		private CArrayFixedSize<CWeakHandle<WorldMapTooltipBaseController>> _tooltips;
		private CInt32 _currentVisibleIndex;

		[Ordinal(1)] 
		[RED("defaultTooltip")] 
		public inkWidgetReference DefaultTooltip
		{
			get => GetProperty(ref _defaultTooltip);
			set => SetProperty(ref _defaultTooltip, value);
		}

		[Ordinal(2)] 
		[RED("policeTooltip")] 
		public inkWidgetReference PoliceTooltip
		{
			get => GetProperty(ref _policeTooltip);
			set => SetProperty(ref _policeTooltip, value);
		}

		[Ordinal(3)] 
		[RED("districtTooltip")] 
		public inkWidgetReference DistrictTooltip
		{
			get => GetProperty(ref _districtTooltip);
			set => SetProperty(ref _districtTooltip, value);
		}

		[Ordinal(4)] 
		[RED("defaultTooltipController")] 
		public CWeakHandle<WorldMapTooltipBaseController> DefaultTooltipController
		{
			get => GetProperty(ref _defaultTooltipController);
			set => SetProperty(ref _defaultTooltipController, value);
		}

		[Ordinal(5)] 
		[RED("policeTooltipController")] 
		public CWeakHandle<WorldMapTooltipBaseController> PoliceTooltipController
		{
			get => GetProperty(ref _policeTooltipController);
			set => SetProperty(ref _policeTooltipController, value);
		}

		[Ordinal(6)] 
		[RED("districtTooltipController")] 
		public CWeakHandle<WorldMapTooltipBaseController> DistrictTooltipController
		{
			get => GetProperty(ref _districtTooltipController);
			set => SetProperty(ref _districtTooltipController, value);
		}

		[Ordinal(7)] 
		[RED("tooltips", 3)] 
		public CArrayFixedSize<CWeakHandle<WorldMapTooltipBaseController>> Tooltips
		{
			get => GetProperty(ref _tooltips);
			set => SetProperty(ref _tooltips, value);
		}

		[Ordinal(8)] 
		[RED("currentVisibleIndex")] 
		public CInt32 CurrentVisibleIndex
		{
			get => GetProperty(ref _currentVisibleIndex);
			set => SetProperty(ref _currentVisibleIndex, value);
		}

		public WorldMapTooltipContainer()
		{
			_currentVisibleIndex = -1;
		}
	}
}
