using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberdeckInventoryStatsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bufferTotal")] 
		public inkTextWidgetReference BufferTotal
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("bufferBase")] 
		public inkTextWidgetReference BufferBase
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("bufferBonus")] 
		public inkTextWidgetReference BufferBonus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("bufferHoverArea")] 
		public inkWidgetReference BufferHoverArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("bufferTooltipPlacement")] 
		public CEnum<gameuiETooltipPlacement> BufferTooltipPlacement
		{
			get => GetPropertyValue<CEnum<gameuiETooltipPlacement>>();
			set => SetPropertyValue<CEnum<gameuiETooltipPlacement>>(value);
		}

		[Ordinal(6)] 
		[RED("ramTotal")] 
		public inkTextWidgetReference RamTotal
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("ramBase")] 
		public inkTextWidgetReference RamBase
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("ramBonus")] 
		public inkTextWidgetReference RamBonus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("ramHoverArea")] 
		public inkWidgetReference RamHoverArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ramTooltipPlacement")] 
		public CEnum<gameuiETooltipPlacement> RamTooltipPlacement
		{
			get => GetPropertyValue<CEnum<gameuiETooltipPlacement>>();
			set => SetPropertyValue<CEnum<gameuiETooltipPlacement>>(value);
		}

		[Ordinal(11)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		public CyberdeckInventoryStatsController()
		{
			BufferTotal = new inkTextWidgetReference();
			BufferBase = new inkTextWidgetReference();
			BufferBonus = new inkTextWidgetReference();
			BufferHoverArea = new inkWidgetReference();
			BufferTooltipPlacement = Enums.gameuiETooltipPlacement.LeftTop;
			RamTotal = new inkTextWidgetReference();
			RamBase = new inkTextWidgetReference();
			RamBonus = new inkTextWidgetReference();
			RamHoverArea = new inkWidgetReference();
			RamTooltipPlacement = Enums.gameuiETooltipPlacement.LeftTop;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
