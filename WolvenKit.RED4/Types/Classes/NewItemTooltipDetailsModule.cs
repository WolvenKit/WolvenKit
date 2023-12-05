using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipDetailsModule : NewItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("statsLine")] 
		public inkWidgetReference StatsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("dedicatedModsLine")] 
		public inkWidgetReference DedicatedModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("dedicatedModsWrapper")] 
		public inkWidgetReference DedicatedModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("dedicatedModsText")] 
		public inkTextWidgetReference DedicatedModsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("modsLine")] 
		public inkWidgetReference ModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("modsWrapper")] 
		public inkWidgetReference ModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("modifierPowerLine")] 
		public inkWidgetReference ModifierPowerLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("modifierPowerLabel")] 
		public inkTextWidgetReference ModifierPowerLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("modifierPowerWrapper")] 
		public inkCompoundWidgetReference ModifierPowerWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
