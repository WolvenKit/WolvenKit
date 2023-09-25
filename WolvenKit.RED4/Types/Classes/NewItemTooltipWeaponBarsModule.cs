using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipWeaponBarsModule : NewItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("bars")] 
		public CArray<inkWidgetReference> Bars
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(5)] 
		[RED("diffBars")] 
		public CArray<inkWidgetReference> DiffBars
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(6)] 
		[RED("betterColorDummyHolder")] 
		public inkWidgetReference BetterColorDummyHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("worseColorDummyHolder")] 
		public inkWidgetReference WorseColorDummyHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("statsToDisplay")] 
		public CArray<CEnum<WeaponBarType>> StatsToDisplay
		{
			get => GetPropertyValue<CArray<CEnum<WeaponBarType>>>();
			set => SetPropertyValue<CArray<CEnum<WeaponBarType>>>(value);
		}

		[Ordinal(9)] 
		[RED("disableSeparators")] 
		public CBool DisableSeparators
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewItemTooltipWeaponBarsModule()
		{
			Bars = new();
			DiffBars = new();
			BetterColorDummyHolder = new inkWidgetReference();
			WorseColorDummyHolder = new inkWidgetReference();
			StatsToDisplay = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
