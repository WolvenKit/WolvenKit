using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsViewController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("StatValueRef")] 
		public inkTextWidgetReference StatValueRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("stat")] 
		public gameStatViewData Stat
		{
			get => GetPropertyValue<gameStatViewData>();
			set => SetPropertyValue<gameStatViewData>(value);
		}

		[Ordinal(5)] 
		[RED("buttonConctroller")] 
		public CWeakHandle<inkButtonController> ButtonConctroller
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		public StatsViewController()
		{
			StatLabelRef = new();
			StatValueRef = new();
			Icon = new();
			Stat = new() { Type = Enums.gamedataStatType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
