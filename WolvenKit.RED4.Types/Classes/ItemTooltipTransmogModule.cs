using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipTransmogModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("buttonHintWidgetRef")] 
		public inkWidgetReference ButtonHintWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHint")] 
		public CWeakHandle<LabelInputDisplayController> ButtonHint
		{
			get => GetPropertyValue<CWeakHandle<LabelInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<LabelInputDisplayController>>(value);
		}

		public ItemTooltipTransmogModule()
		{
			ButtonHintWidgetRef = new();
			LabelRef = new();
		}
	}
}
