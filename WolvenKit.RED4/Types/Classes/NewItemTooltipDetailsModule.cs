using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipDetailsModule : NewItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("statsLine")] 
		public inkWidgetReference StatsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("dedicatedModsLine")] 
		public inkWidgetReference DedicatedModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("dedicatedModsWrapper")] 
		public inkWidgetReference DedicatedModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("dedicatedModsText")] 
		public inkTextWidgetReference DedicatedModsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("modsLine")] 
		public inkWidgetReference ModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("modsWrapper")] 
		public inkWidgetReference ModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("modifierPowerLine")] 
		public inkWidgetReference ModifierPowerLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("modifierPowerLabel")] 
		public inkTextWidgetReference ModifierPowerLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("modifierPowerWrapper")] 
		public inkCompoundWidgetReference ModifierPowerWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public NewItemTooltipDetailsModule()
		{
			StatsLine = new inkWidgetReference();
			StatsWrapper = new inkWidgetReference();
			StatsContainer = new inkCompoundWidgetReference();
			DedicatedModsLine = new inkWidgetReference();
			DedicatedModsWrapper = new inkWidgetReference();
			DedicatedModsText = new inkTextWidgetReference();
			ModsLine = new inkWidgetReference();
			ModsWrapper = new inkWidgetReference();
			ModsContainer = new inkCompoundWidgetReference();
			ModifierPowerLine = new inkWidgetReference();
			ModifierPowerLabel = new inkTextWidgetReference();
			ModifierPowerWrapper = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
