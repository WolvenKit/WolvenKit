using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldMapTooltipContainer : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("defaultTooltip")] 
		public inkWidgetReference DefaultTooltip
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("policeTooltip")] 
		public inkWidgetReference PoliceTooltip
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("districtTooltip")] 
		public inkWidgetReference DistrictTooltip
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("defaultTooltipController")] 
		public CWeakHandle<WorldMapTooltipBaseController> DefaultTooltipController
		{
			get => GetPropertyValue<CWeakHandle<WorldMapTooltipBaseController>>();
			set => SetPropertyValue<CWeakHandle<WorldMapTooltipBaseController>>(value);
		}

		[Ordinal(5)] 
		[RED("policeTooltipController")] 
		public CWeakHandle<WorldMapTooltipBaseController> PoliceTooltipController
		{
			get => GetPropertyValue<CWeakHandle<WorldMapTooltipBaseController>>();
			set => SetPropertyValue<CWeakHandle<WorldMapTooltipBaseController>>(value);
		}

		[Ordinal(6)] 
		[RED("districtTooltipController")] 
		public CWeakHandle<WorldMapTooltipBaseController> DistrictTooltipController
		{
			get => GetPropertyValue<CWeakHandle<WorldMapTooltipBaseController>>();
			set => SetPropertyValue<CWeakHandle<WorldMapTooltipBaseController>>(value);
		}

		[Ordinal(7)] 
		[RED("tooltips", 3)] 
		public CArrayFixedSize<CWeakHandle<WorldMapTooltipBaseController>> Tooltips
		{
			get => GetPropertyValue<CArrayFixedSize<CWeakHandle<WorldMapTooltipBaseController>>>();
			set => SetPropertyValue<CArrayFixedSize<CWeakHandle<WorldMapTooltipBaseController>>>(value);
		}

		[Ordinal(8)] 
		[RED("currentVisibleIndex")] 
		public CInt32 CurrentVisibleIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public WorldMapTooltipContainer()
		{
			DefaultTooltip = new();
			PoliceTooltip = new();
			DistrictTooltip = new();
			Tooltips = new(3);
			CurrentVisibleIndex = -1;
		}
	}
}
