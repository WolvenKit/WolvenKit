using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipWeaponInfoModule : ItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("perHitText")] 
		public inkTextWidgetReference PerHitText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("attacksPerSecondText")] 
		public inkTextWidgetReference AttacksPerSecondText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("nonLethal")] 
		public inkTextWidgetReference NonLethal
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("scopeIndicator")] 
		public inkWidgetReference ScopeIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("silencerIndicator")] 
		public inkWidgetReference SilencerIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("ammoText")] 
		public inkTextWidgetReference AmmoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public ItemTooltipWeaponInfoModule()
		{
			Wrapper = new inkWidgetReference();
			Arrow = new inkImageWidgetReference();
			DpsText = new inkTextWidgetReference();
			PerHitText = new inkTextWidgetReference();
			AttacksPerSecondText = new inkTextWidgetReference();
			NonLethal = new inkTextWidgetReference();
			ScopeIndicator = new inkWidgetReference();
			SilencerIndicator = new inkWidgetReference();
			AmmoText = new inkTextWidgetReference();
			AmmoWrapper = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
