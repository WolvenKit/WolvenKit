using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipCyberwareWeaponModule : ItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("bars")] 
		public CArray<inkWidgetReference> Bars
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(6)] 
		[RED("diffBars")] 
		public CArray<inkWidgetReference> DiffBars
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(7)] 
		[RED("betterColorDummyHolder")] 
		public inkWidgetReference BetterColorDummyHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("worseColorDummyHolder")] 
		public inkWidgetReference WorseColorDummyHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("statsToDisplay")] 
		public CArray<CEnum<WeaponBarType>> StatsToDisplay
		{
			get => GetPropertyValue<CArray<CEnum<WeaponBarType>>>();
			set => SetPropertyValue<CArray<CEnum<WeaponBarType>>>(value);
		}

		[Ordinal(10)] 
		[RED("disableSeparators")] 
		public CBool DisableSeparators
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemTooltipCyberwareWeaponModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
