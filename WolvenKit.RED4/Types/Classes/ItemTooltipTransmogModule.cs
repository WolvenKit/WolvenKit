using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipTransmogModule : ItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("buttonHintWidgetRef")] 
		public inkWidgetReference ButtonHintWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buttonHint")] 
		public CWeakHandle<LabelInputDisplayController> ButtonHint
		{
			get => GetPropertyValue<CWeakHandle<LabelInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<LabelInputDisplayController>>(value);
		}

		public ItemTooltipTransmogModule()
		{
			ButtonHintWidgetRef = new inkWidgetReference();
			LabelRef = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
